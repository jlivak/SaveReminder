using System.ComponentModel;

namespace SaveReminder
{
    partial class AddProgramDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProgramDialog));
            this.ChooseProgramLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectSpecificProgramLabel = new System.Windows.Forms.Label();
            this.ProcessListBox = new System.Windows.Forms.ListBox();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.DividerPanel = new System.Windows.Forms.Panel();
            this.FrequencyTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenProcessDialog = new System.Windows.Forms.OpenFileDialog();
            this.FrequencyValidationPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ChooseProgramLabel
            // 
            this.ChooseProgramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ChooseProgramLabel.Location = new System.Drawing.Point(12, 9);
            this.ChooseProgramLabel.Name = "ChooseProgramLabel";
            this.ChooseProgramLabel.Size = new System.Drawing.Size(295, 23);
            this.ChooseProgramLabel.TabIndex = 0;
            this.ChooseProgramLabel.Text = "Choose a running program:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(12, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Or";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectSpecificProgramLabel
            // 
            this.SelectSpecificProgramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.SelectSpecificProgramLabel.Location = new System.Drawing.Point(12, 277);
            this.SelectSpecificProgramLabel.Name = "SelectSpecificProgramLabel";
            this.SelectSpecificProgramLabel.Size = new System.Drawing.Size(295, 23);
            this.SelectSpecificProgramLabel.TabIndex = 2;
            this.SelectSpecificProgramLabel.Text = "Select a specific program:";
            // 
            // ProcessListBox
            // 
            this.ProcessListBox.FormattingEnabled = true;
            this.ProcessListBox.Location = new System.Drawing.Point(23, 35);
            this.ProcessListBox.Name = "ProcessListBox";
            this.ProcessListBox.Size = new System.Drawing.Size(273, 199);
            this.ProcessListBox.TabIndex = 3;
            this.ProcessListBox.SelectedIndexChanged += new System.EventHandler(this.ProcessListBox_SelectedIndexChanged);
            // 
            // PathTextBox
            // 
            this.PathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.PathTextBox.Location = new System.Drawing.Point(23, 303);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(273, 23);
            this.PathTextBox.TabIndex = 4;
            this.PathTextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.BrowseButton.Location = new System.Drawing.Point(212, 332);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(84, 29);
            this.BrowseButton.TabIndex = 5;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // DividerPanel
            // 
            this.DividerPanel.BackColor = System.Drawing.Color.DimGray;
            this.DividerPanel.Location = new System.Drawing.Point(12, 376);
            this.DividerPanel.Name = "DividerPanel";
            this.DividerPanel.Size = new System.Drawing.Size(295, 2);
            this.DividerPanel.TabIndex = 6;
            // 
            // FrequencyTextBox
            // 
            this.FrequencyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FrequencyTextBox.Location = new System.Drawing.Point(209, 420);
            this.FrequencyTextBox.MaxLength = 3;
            this.FrequencyTextBox.Name = "FrequencyTextBox";
            this.FrequencyTextBox.Size = new System.Drawing.Size(39, 23);
            this.FrequencyTextBox.TabIndex = 7;
            this.FrequencyTextBox.Text = "10";
            this.FrequencyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FrequencyTextBox.TextChanged += new System.EventHandler(this.FrequencyTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(12, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reminder Frequency:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(257, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "minutes";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(155, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Every";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(116, 462);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(88, 34);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenProcessDialog
            // 
            this.OpenProcessDialog.FileName = "openFileDialog1";
            this.OpenProcessDialog.Filter = "Executables(*.exe;*.msi)|*.exe;*.msi";
            // 
            // FrequencyValidationPanel
            // 
            this.FrequencyValidationPanel.BackColor = System.Drawing.Color.Red;
            this.FrequencyValidationPanel.Location = new System.Drawing.Point(206, 417);
            this.FrequencyValidationPanel.Name = "FrequencyValidationPanel";
            this.FrequencyValidationPanel.Size = new System.Drawing.Size(45, 29);
            this.FrequencyValidationPanel.TabIndex = 12;
            this.FrequencyValidationPanel.Visible = false;
            // 
            // AddProgramDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 505);
            this.Controls.Add(this.FrequencyTextBox);
            this.Controls.Add(this.FrequencyValidationPanel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DividerPanel);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.ProcessListBox);
            this.Controls.Add(this.SelectSpecificProgramLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChooseProgramLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "AddProgramDialog";
            this.ShowIcon = false;
            this.Text = "Add Program";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label ChooseProgramLabel;
        private System.Windows.Forms.Panel DividerPanel;
        private System.Windows.Forms.TextBox FrequencyTextBox;
        private System.Windows.Forms.Panel FrequencyValidationPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog OpenProcessDialog;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.ListBox ProcessListBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label SelectSpecificProgramLabel;

        #endregion
    }
}