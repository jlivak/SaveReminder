using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Timers;
using System.Diagnostics;
using System.IO;
using SaveReminderStorage;

namespace SaveReminder
{
    class SaveReminderContext : ApplicationContext
    {
        private DateTime? _pauseUntil = null;
        private bool _pausedIndefinitely = false;
        private Dictionary<string, DateTime> _lastReminderDictionary = new Dictionary<string, DateTime>(); //<processName, lastRemindedTime>
        private UserDataV1 _userConfig; 
        private System.Timers.Timer _timer = new System.Timers.Timer();
        private Icon _icon;

        private NotifyIcon _notifyIcon;

        private MenuItem _pauseOneHourMenuItem;
        private MenuItem _pauseTwelveHoursMenuItem;
        private MenuItem _pauseIndefinitelyMenuItem;
        private MenuItem _resumeMenuItem;
        
        private readonly string _configFileName = "user.config";
        private string _pathToConfigFolder
        {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SaveReminder\\"; }
        }
        private string _pathToConfig
        {
            get { return _pathToConfigFolder + _configFileName; }
        }
        
        public SaveReminderContext()
        {
            _notifyIcon = new NotifyIcon();
            _icon = Icon.FromHandle(Properties.Resources.baseline_save_white_24dp.GetHicon());
            _notifyIcon.Icon = _icon;

            _pauseOneHourMenuItem = new MenuItem("Pause For an Hour", OnPauseOneHour);
            _pauseTwelveHoursMenuItem = new MenuItem("Pause For 12 Hours", OnPauseTwelveHours);
            _pauseIndefinitelyMenuItem = new MenuItem("Pause Indefinitely", OnPauseIndefinitely);
            _resumeMenuItem = new MenuItem("Resume", OnResume);
            _resumeMenuItem.Visible = false;

            _notifyIcon.ContextMenu = new ContextMenu(new MenuItem[] {
                _pauseOneHourMenuItem,
                _pauseTwelveHoursMenuItem,
                _pauseIndefinitelyMenuItem,
                _resumeMenuItem,
                new MenuItem("Configuration", OnConfiguration),
                new MenuItem("Exit", OnExit)
            });
            _notifyIcon.Visible = false;
            _notifyIcon.Text = "Save Reminder";
            _notifyIcon.Visible = true;
            
            if (File.Exists(_pathToConfig))
            {
                _userConfig = ReadWriteHelper.ReadFromBinaryFile<UserDataV1>(_pathToConfig);
            }
            else
            {
                _notifyIcon.BalloonTipText = "Couldn't find config file!  Please use the config utility to setup a reminder.";
                _notifyIcon.ShowBalloonTip(5000);
                _userConfig = new UserDataV1();
            }

            _timer.Interval = 65000; // 65 seconds  
            _timer.AutoReset = true;
            _timer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimer);
            _timer.Start();

            OnTimer(null, null);
        }

        private void OnTimer(object sender, ElapsedEventArgs e)
        {
            if (_pausedIndefinitely)
                return;

            if (_pauseUntil.HasValue)
            {
                if (_pauseUntil < DateTime.Now)
                {
                    OnResume(null, null);
                }
                else
                {
                    return;
                }
            }
            
            foreach (var process in _userConfig.Programs)
            {
                var processes = Process.GetProcesses().Where(p => p.ProcessName.ToLower() == process.ExecutableName.Replace(".exe", "").ToLower());
                if (processes.Any())
                {
                    if (_lastReminderDictionary.ContainsKey(process.ExecutableName))
                    {
                        if (_lastReminderDictionary[process.ExecutableName].AddMinutes(process.Interval) < DateTime.Now)
                        {
                            _notifyIcon.BalloonTipText = "Don't forget to save! (" + process.ExecutableName + ")";
                            _notifyIcon.ShowBalloonTip(5000);
                            _lastReminderDictionary[process.ExecutableName] = DateTime.Now;
                        }
                    }
                    else
                    {
                        _notifyIcon.BalloonTipText = "Don't forget to save! (" + process.ExecutableName + ")";
                        _notifyIcon.ShowBalloonTip(5000);
                        _lastReminderDictionary.Add(process.ExecutableName, DateTime.Now);
                    }
                }
            }
        }

        protected void OnExit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            _notifyIcon.Visible = false;

            Application.Exit();
        }

        protected void OnPauseIndefinitely(object sender, EventArgs e)
        {
            _pausedIndefinitely = true;
            _pauseIndefinitelyMenuItem.Visible = false;
            _pauseOneHourMenuItem.Visible = false;
            _pauseTwelveHoursMenuItem.Visible = false;
            _resumeMenuItem.Visible = true;
        }
        
        protected void OnPauseOneHour(object sender, EventArgs e)
        {
            _pauseUntil = DateTime.Now.AddHours(1);
            _pauseIndefinitelyMenuItem.Visible = false;
            _pauseOneHourMenuItem.Visible = false;
            _pauseTwelveHoursMenuItem.Visible = false;
            _resumeMenuItem.Visible = true;
        }
        
        protected void OnPauseTwelveHours(object sender, EventArgs e)
        {
            _pauseUntil = DateTime.Now.AddHours(12);
            _pauseIndefinitelyMenuItem.Visible = false;
            _pauseOneHourMenuItem.Visible = false;
            _pauseTwelveHoursMenuItem.Visible = false;
            _resumeMenuItem.Visible = true;
        }

        protected void OnResume(object sender, EventArgs e)
        {
            _pausedIndefinitely = false;
            _pauseUntil = null;
            _pauseIndefinitelyMenuItem.Visible = true;
            _pauseOneHourMenuItem.Visible = true;
            _pauseTwelveHoursMenuItem.Visible = true;
            _resumeMenuItem.Visible = false;
        }
        
        protected void OnConfiguration(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = System.Reflection.Assembly.GetEntryAssembly().Location.Replace("SaveReminder.service", "") + "SaveReminder.exe";
            p.Start();
        }
    }
}
