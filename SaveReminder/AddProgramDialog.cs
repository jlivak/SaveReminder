using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using SaveReminderStorage;

namespace SaveReminder
{
    public partial class AddProgramDialog : Form
    {
        private bool _listInitialized = false;
        public ProgramContainer ProgramContainerToCreate = null;
        
        public AddProgramDialog()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            
            var windowsPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);

            var allProcesses = Process.GetProcesses().ToList();
            var processList = new List<Process>();
            foreach (var process in allProcesses)
            {
                try
                {
                    if (process != null && !process.MainModule.FileName.StartsWith(windowsPath))
                    {
                        processList.Add(process);
                    }
                }
                catch (Exception ex)
                {
                    //Ignore any process whose path we can't access
                }
            }
            
            var listBoxDataSource = new List<ProcessListItem>();
            processList.ForEach(p => listBoxDataSource.Add(new ProcessListItem()
                {
                    BaseProcess = p, 
                    ProcessName = p.ProcessName + " (" + StripPath(p.MainModule.FileName) + ")"
                }
            ));

            listBoxDataSource = listBoxDataSource.OrderBy(p => p.ProcessName)
                .GroupBy(p => p.ProcessName)
                .Select(p => p.First()).ToList();
            ProcessListBox.DisplayMember = "ProcessName";
            ProcessListBox.DataSource = listBoxDataSource;
            ProcessListBox.SelectedItem = null;
            _listInitialized = true;
        }

        private static string StripPath(string fullPath)
        {
            var slashIndex = fullPath.LastIndexOf("\\");
            slashIndex = fullPath.LastIndexOf("/") > slashIndex ? fullPath.LastIndexOf("/") : slashIndex;
            if (slashIndex > 0)
            {
                return fullPath.Substring(slashIndex + 1);
            }

            return fullPath;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            var result = OpenProcessDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                PathTextBox.Text = StripPath(OpenProcessDialog.FileName);
            }
        }

        private void ProcessListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_listInitialized) return;
            
            if (ProcessListBox.SelectedItem != null)
            {
                PathTextBox.Text =
                    StripPath(((ProcessListItem) ProcessListBox.SelectedItem).BaseProcess.MainModule.FileName);
            }
        }

        private void UpdateValidation()
        {
            int parsedInt = -1;
            var result = int.TryParse(FrequencyTextBox.Text, out parsedInt);
            if (!result || parsedInt < 1)
            {
                FrequencyValidationPanel.Visible = true;
                SaveButton.Enabled = false;
                return;
            }

            FrequencyValidationPanel.Visible = false;
            if (PathTextBox.Text.Length > 0)
            {
                SaveButton.Enabled = true;
            }
        }

        private void FrequencyTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateValidation();
        }

        private void PathTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateValidation();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            ProgramContainerToCreate = new ProgramContainer(PathTextBox.Text, int.Parse(FrequencyTextBox.Text));
            Close();
        }
    }
}