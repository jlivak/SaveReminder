using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security;
using System.Windows.Forms;
using System.Timers;
using Microsoft.Win32;
using Timer = System.Timers.Timer;
using SaveReminderStorage;

namespace SaveReminder
{
    public partial class ConfigGui : Form
    {
        public readonly string Version = "1.1";
        
        private UserDataV1 _userConfig;
        private bool _listInitialized = false;
        private readonly string _configFileName = "user.config";
        private Timer _updateRunningStatusTimer = new Timer(500);

        private string _pathToConfigFolder
        {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SaveReminder\\"; }
        }
        private string _pathToConfig
        {
            get { return _pathToConfigFolder + _configFileName; }
        }

        public ConfigGui()
        {
            InitializeComponent();
            VersionLabel.Text = "Version " + Version;

            _updateRunningStatusTimer.Elapsed += (o, args) => OnUpdateRunningStatus();
            _updateRunningStatusTimer.AutoReset = false;

            if (File.Exists(_pathToConfig))
            {
                _userConfig = ReadWriteHelper.ReadFromBinaryFile<UserDataV1>(_pathToConfig);
            }
            else
            {
                _userConfig = new UserDataV1();
            }

            ProgramListBox.DataSource = _userConfig.Programs;
            ProgramListBox.SelectedItem = null;
            _listInitialized = true;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            OnUpdateRunningStatus();
            
            RegistryKey rk =
                Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", false);
            
            if (rk.GetValue("SaveReminderService") != null)
            {
                RunOnStartupCheckbox.Checked = true;
            }

            RunOnStartupCheckbox.CheckedChanged += RunOnStartupCheckbox_CheckedChanged;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartService();
            StartButton.Enabled = false;
            StopButton.Enabled = false;
            _updateRunningStatusTimer.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            var runningProcess = Process.GetProcesses().Where(p => p.ProcessName == "SaveReminder.service").ToList();
            if (runningProcess.Any())
            {
                runningProcess.ForEach(p => p.Kill());
            }

            StartButton.Enabled = false;
            StopButton.Enabled = false;
            _updateRunningStatusTimer.Start();
        }

        private void OnUpdateRunningStatus()
        {
            var processes = Process.GetProcesses().Where(p => p.ProcessName == "SaveReminder.service");
            if (processes.Any())
            {
                Invoke(new Action(() =>
                {
                    StoppedLabel.Visible = false;
                    RunningLabel.Visible = true;
                    StartButton.Enabled = false;
                    StopButton.Enabled = true;
                }));
            }
            else
            {
                Invoke(new Action(() =>
                {
                    StoppedLabel.Visible = true;
                    RunningLabel.Visible = false;
                    StartButton.Enabled = true;
                    StopButton.Enabled = false;
                }));
            }
        }

        private void RunOnStartupCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (RunOnStartupCheckbox.Checked)
                {
                    RegistryKey rk =
                        Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    if (rk.GetValue("SaveReminderService") == null)
                        rk.SetValue("SaveReminderService", "cmd.exe /c start \"\" \"" + System.AppContext.BaseDirectory + "SaveReminder.service" + "\"");
                }
                else
                {
                    RegistryKey rk =
                        Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    if (rk.GetValue("SaveReminderService") != null)
                        rk.DeleteValue("SaveReminderService");
                }
                
                StartupErrorLabel.Visible = false;
            }
            catch (SecurityException ex)
            {
                StartupErrorLabel.Visible = true;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var dialog = new AddProgramDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK && dialog.ProgramContainerToCreate != null)
            {
                if (_userConfig.Programs.Any(p => p.ExecutableName == dialog.ProgramContainerToCreate.ExecutableName))
                {
                    DuplicateValidationLabel.Visible = true;
                    return;
                }

                DuplicateValidationLabel.Visible = false;

                _userConfig.Programs.Add(dialog.ProgramContainerToCreate);
                ProgramListBox.DataSource = null;
                ProgramListBox.DataSource = _userConfig.Programs;

                ReadWriteHelper.CreateFolderIfMissing(_pathToConfigFolder);
                ReadWriteHelper.WriteToBinaryFile(_pathToConfig, _userConfig);
                
                //If service is currently running, restart it so it loads new config
                var runningProcess = Process.GetProcesses().Where(p => p.ProcessName == "SaveReminder.service").ToList();
                if (runningProcess.Any())
                {
                    runningProcess.ForEach(p => p.Kill());

                    StartService();
                }
            }
        }

        private void ProgramListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_listInitialized) return;

            if (ProgramListBox.SelectedItem != null)
            {
                RemoveButton.Enabled = true;
            }
            else
            {
                RemoveButton.Enabled = false;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ProgramListBox.SelectedItem != null)
            {
                DuplicateValidationLabel.Visible = false;
                
                _userConfig.Programs.RemoveAll(p =>
                    p.ExecutableName == ((ProgramContainer) ProgramListBox.SelectedItem).ExecutableName);
                
                ReadWriteHelper.CreateFolderIfMissing(_pathToConfigFolder);
                ReadWriteHelper.WriteToBinaryFile(_pathToConfig, _userConfig);
                
                ProgramListBox.DataSource = null;
                ProgramListBox.DataSource = _userConfig.Programs;
            }
        }

        private void StartService()
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "SaveReminder.service";
            p.StartInfo.UseShellExecute  = false;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
        }
    }
}