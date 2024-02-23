
namespace BMWFILESYSTEM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.doNotDeleteCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BrowseSourceButton = new System.Windows.Forms.Button();
            this.BrowseDestinationButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.sourceDirTextBox = new System.Windows.Forms.TextBox();
            this.destinationDirTextBox = new System.Windows.Forms.TextBox();
            this.CompareAndReplicateButton = new System.Windows.Forms.Button();
            this.ViewLogsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.replicationProgressBar = new System.Windows.Forms.ProgressBar();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // doNotDeleteCheckBox
            // 
            this.doNotDeleteCheckBox.AutoSize = true;
            this.doNotDeleteCheckBox.Location = new System.Drawing.Point(331, 164);
            this.doNotDeleteCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.doNotDeleteCheckBox.Name = "doNotDeleteCheckBox";
            this.doNotDeleteCheckBox.Size = new System.Drawing.Size(136, 17);
            this.doNotDeleteCheckBox.TabIndex = 0;
            this.doNotDeleteCheckBox.Text = "Include Sub Directories";
            this.doNotDeleteCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Progress Bar ";
            // 
            // BrowseSourceButton
            // 
            this.BrowseSourceButton.Location = new System.Drawing.Point(550, 73);
            this.BrowseSourceButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BrowseSourceButton.Name = "BrowseSourceButton";
            this.BrowseSourceButton.Size = new System.Drawing.Size(50, 25);
            this.BrowseSourceButton.TabIndex = 4;
            this.BrowseSourceButton.Text = "Browser";
            this.BrowseSourceButton.UseVisualStyleBackColor = true;
            this.BrowseSourceButton.Click += new System.EventHandler(this.BrowseSourceButton_Click);
            // 
            // BrowseDestinationButton
            // 
            this.BrowseDestinationButton.Location = new System.Drawing.Point(550, 94);
            this.BrowseDestinationButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BrowseDestinationButton.Name = "BrowseDestinationButton";
            this.BrowseDestinationButton.Size = new System.Drawing.Size(50, 25);
            this.BrowseDestinationButton.TabIndex = 5;
            this.BrowseDestinationButton.Text = "Browser";
            this.BrowseDestinationButton.UseVisualStyleBackColor = true;
            this.BrowseDestinationButton.Click += new System.EventHandler(this.BrowseDestinationButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // sourceDirTextBox
            // 
            this.sourceDirTextBox.Location = new System.Drawing.Point(303, 77);
            this.sourceDirTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sourceDirTextBox.Name = "sourceDirTextBox";
            this.sourceDirTextBox.Size = new System.Drawing.Size(236, 20);
            this.sourceDirTextBox.TabIndex = 6;
            // 
            // destinationDirTextBox
            // 
            this.destinationDirTextBox.Location = new System.Drawing.Point(303, 98);
            this.destinationDirTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.destinationDirTextBox.Name = "destinationDirTextBox";
            this.destinationDirTextBox.Size = new System.Drawing.Size(236, 20);
            this.destinationDirTextBox.TabIndex = 7;
            // 
            // CompareAndReplicateButton
            // 
            this.CompareAndReplicateButton.Location = new System.Drawing.Point(331, 192);
            this.CompareAndReplicateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CompareAndReplicateButton.Name = "CompareAndReplicateButton";
            this.CompareAndReplicateButton.Size = new System.Drawing.Size(87, 25);
            this.CompareAndReplicateButton.TabIndex = 8;
            this.CompareAndReplicateButton.Text = "Replicate";
            this.CompareAndReplicateButton.UseVisualStyleBackColor = true;
            this.CompareAndReplicateButton.Click += new System.EventHandler(this.CompareAndReplicateButton_Click);
            // 
            // ViewLogsButton
            // 
            this.ViewLogsButton.Location = new System.Drawing.Point(303, 297);
            this.ViewLogsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewLogsButton.Name = "ViewLogsButton";
            this.ViewLogsButton.Size = new System.Drawing.Size(87, 25);
            this.ViewLogsButton.TabIndex = 9;
            this.ViewLogsButton.Text = "View &Log";
            this.ViewLogsButton.UseVisualStyleBackColor = true;
            this.ViewLogsButton.Click += new System.EventHandler(this.ViewLogsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(697, 297);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(50, 25);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // replicationProgressBar
            // 
            this.replicationProgressBar.Location = new System.Drawing.Point(303, 248);
            this.replicationProgressBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.replicationProgressBar.Name = "replicationProgressBar";
            this.replicationProgressBar.Size = new System.Drawing.Size(347, 19);
            this.replicationProgressBar.TabIndex = 11;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(177, 357);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(551, 81);
            this.dataGridView.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 492);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.replicationProgressBar);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ViewLogsButton);
            this.Controls.Add(this.CompareAndReplicateButton);
            this.Controls.Add(this.destinationDirTextBox);
            this.Controls.Add(this.sourceDirTextBox);
            this.Controls.Add(this.BrowseDestinationButton);
            this.Controls.Add(this.BrowseSourceButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doNotDeleteCheckBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox doNotDeleteCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BrowseSourceButton;
        private System.Windows.Forms.Button BrowseDestinationButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox sourceDirTextBox;
        private System.Windows.Forms.TextBox destinationDirTextBox;
        private System.Windows.Forms.Button CompareAndReplicateButton;
        private System.Windows.Forms.Button ViewLogsButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ProgressBar replicationProgressBar;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

