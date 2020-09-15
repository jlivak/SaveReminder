using System.ComponentModel;

namespace SaveReminder
{
    partial class ConfigGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigGui));
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StoppedLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.RunOnStartupCheckbox = new System.Windows.Forms.CheckBox();
            this.DividerPanel = new System.Windows.Forms.Panel();
            this.ProgramListBox = new System.Windows.Forms.ListBox();
            this.ReminderProgramsLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.RunningLabel = new System.Windows.Forms.Label();
            this.StartupErrorLabel = new System.Windows.Forms.Label();
            this.Divider2PAnel = new System.Windows.Forms.Panel();
            this.DirectionsLabel = new System.Windows.Forms.Label();
            this.HowToUseLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.DuplicateValidationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.StatusLabel.Location = new System.Drawing.Point(15, 189);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(201, 23);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "Service Status";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StoppedLabel
            // 
            this.StoppedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.StoppedLabel.ForeColor = System.Drawing.Color.Crimson;
            this.StoppedLabel.Location = new System.Drawing.Point(15, 212);
            this.StoppedLabel.Name = "StoppedLabel";
            this.StoppedLabel.Size = new System.Drawing.Size(201, 54);
            this.StoppedLabel.TabIndex = 1;
            this.StoppedLabel.Text = "STOPPED";
            this.StoppedLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.StartButton.Location = new System.Drawing.Point(54, 268);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(119, 35);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.StopButton.Location = new System.Drawing.Point(54, 309);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(119, 35);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // RunOnStartupCheckbox
            // 
            this.RunOnStartupCheckbox.Location = new System.Drawing.Point(62, 357);
            this.RunOnStartupCheckbox.Name = "RunOnStartupCheckbox";
            this.RunOnStartupCheckbox.Size = new System.Drawing.Size(105, 24);
            this.RunOnStartupCheckbox.TabIndex = 4;
            this.RunOnStartupCheckbox.Text = "Run on Startup";
            this.RunOnStartupCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RunOnStartupCheckbox.UseVisualStyleBackColor = true;
            // 
            // DividerPanel
            // 
            this.DividerPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DividerPanel.Location = new System.Drawing.Point(228, 178);
            this.DividerPanel.Name = "DividerPanel";
            this.DividerPanel.Size = new System.Drawing.Size(2, 278);
            this.DividerPanel.TabIndex = 5;
            // 
            // ProgramListBox
            // 
            this.ProgramListBox.FormattingEnabled = true;
            this.ProgramListBox.Location = new System.Drawing.Point(279, 229);
            this.ProgramListBox.Name = "ProgramListBox";
            this.ProgramListBox.Size = new System.Drawing.Size(188, 186);
            this.ProgramListBox.TabIndex = 6;
            this.ProgramListBox.SelectedIndexChanged += new System.EventHandler(this.ProgramListBox_SelectedIndexChanged);
            // 
            // ReminderProgramsLabel
            // 
            this.ReminderProgramsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ReminderProgramsLabel.Location = new System.Drawing.Point(279, 203);
            this.ReminderProgramsLabel.Name = "ReminderProgramsLabel";
            this.ReminderProgramsLabel.Size = new System.Drawing.Size(162, 23);
            this.ReminderProgramsLabel.TabIndex = 7;
            this.ReminderProgramsLabel.Text = "Reminder Programs:";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.AddButton.Location = new System.Drawing.Point(482, 229);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(97, 33);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Enabled = false;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.RemoveButton.Location = new System.Drawing.Point(482, 268);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(97, 33);
            this.RemoveButton.TabIndex = 9;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // RunningLabel
            // 
            this.RunningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.RunningLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.RunningLabel.Location = new System.Drawing.Point(15, 212);
            this.RunningLabel.Name = "RunningLabel";
            this.RunningLabel.Size = new System.Drawing.Size(201, 54);
            this.RunningLabel.TabIndex = 10;
            this.RunningLabel.Text = "RUNNING";
            this.RunningLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StartupErrorLabel
            // 
            this.StartupErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.StartupErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.StartupErrorLabel.Location = new System.Drawing.Point(18, 385);
            this.StartupErrorLabel.Name = "StartupErrorLabel";
            this.StartupErrorLabel.Size = new System.Drawing.Size(190, 49);
            this.StartupErrorLabel.TabIndex = 11;
            this.StartupErrorLabel.Text = "Failed to set startup.  Try running this program as an admin and trying again.";
            this.StartupErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StartupErrorLabel.Visible = false;
            // 
            // Divider2PAnel
            // 
            this.Divider2PAnel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Divider2PAnel.Location = new System.Drawing.Point(12, 164);
            this.Divider2PAnel.Name = "Divider2PAnel";
            this.Divider2PAnel.Size = new System.Drawing.Size(587, 2);
            this.Divider2PAnel.TabIndex = 6;
            // 
            // DirectionsLabel
            // 
            this.DirectionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.DirectionsLabel.Location = new System.Drawing.Point(13, 31);
            this.DirectionsLabel.Name = "DirectionsLabel";
            this.DirectionsLabel.Size = new System.Drawing.Size(587, 124);
            this.DirectionsLabel.TabIndex = 12;
            this.DirectionsLabel.Text = resources.GetString("DirectionsLabel.Text");
            // 
            // HowToUseLabel
            // 
            this.HowToUseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.HowToUseLabel.Location = new System.Drawing.Point(11, 8);
            this.HowToUseLabel.Name = "HowToUseLabel";
            this.HowToUseLabel.Size = new System.Drawing.Size(589, 23);
            this.HowToUseLabel.TabIndex = 13;
            this.HowToUseLabel.Text = "How To Use";
            this.HowToUseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.VersionLabel.Location = new System.Drawing.Point(480, 449);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(134, 23);
            this.VersionLabel.TabIndex = 14;
            this.VersionLabel.Text = "Version 0.0";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DuplicateValidationLabel
            // 
            this.DuplicateValidationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.DuplicateValidationLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.DuplicateValidationLabel.Location = new System.Drawing.Point(251, 418);
            this.DuplicateValidationLabel.Name = "DuplicateValidationLabel";
            this.DuplicateValidationLabel.Size = new System.Drawing.Size(297, 49);
            this.DuplicateValidationLabel.TabIndex = 15;
            this.DuplicateValidationLabel.Text = "Attempted to add a duplicate program.  To update an entry, please remove the prog" + "ram reminder and re-create it.";
            this.DuplicateValidationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DuplicateValidationLabel.Visible = false;
            // 
            // ConfigGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 471);
            this.Controls.Add(this.DuplicateValidationLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.HowToUseLabel);
            this.Controls.Add(this.DirectionsLabel);
            this.Controls.Add(this.Divider2PAnel);
            this.Controls.Add(this.StartupErrorLabel);
            this.Controls.Add(this.RunningLabel);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ReminderProgramsLabel);
            this.Controls.Add(this.ProgramListBox);
            this.Controls.Add(this.DividerPanel);
            this.Controls.Add(this.RunOnStartupCheckbox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StoppedLabel);
            this.Controls.Add(this.StatusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "ConfigGui";
            this.Text = "Save Reminder Configuration";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label DirectionsLabel;
        private System.Windows.Forms.Panel Divider2PAnel;
        private System.Windows.Forms.Panel DividerPanel;
        private System.Windows.Forms.Label DuplicateValidationLabel;
        private System.Windows.Forms.Label HowToUseLabel;
        private System.Windows.Forms.ListBox ProgramListBox;
        private System.Windows.Forms.Label ReminderProgramsLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label RunningLabel;
        private System.Windows.Forms.CheckBox RunOnStartupCheckbox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label StartupErrorLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label StoppedLabel;
        private System.Windows.Forms.Label VersionLabel;

        #endregion
    }
}