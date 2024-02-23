using BMWFILESYSTEM.Models;
using BMWFILESYSTEM.Repositoy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BMWFILESYSTEM
{
    public partial class Form1 : Form
    {
        private readonly IDirectoryComparisonRepository _repository;
        private List<FileComparisonResult> _comparisonResults;


        public Form1(IDirectoryComparisonRepository repository)
        {
            InitializeComponent();           
            _repository = repository;
        }      

        private void Form1_Load(object sender, EventArgs e)
        {
            sourceDirTextBox.Text = Properties.Settings.Default.SourceDirectory;
            destinationDirTextBox.Text = Properties.Settings.Default.DestinationDirectory;

        }

        private void BrowseSourceButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var folderBrowserDialog = new FolderBrowserDialog())
                {
                    DialogResult result = folderBrowserDialog.ShowDialog();
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                    {
                        sourceDirTextBox.Text = folderBrowserDialog.SelectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while browsing for the source directory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BrowseDestinationButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var folderBrowserDialog = new FolderBrowserDialog())
                {
                    DialogResult result = folderBrowserDialog.ShowDialog();
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                    {
                        destinationDirTextBox.Text = folderBrowserDialog.SelectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while browsing for the destination directory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CompareAndReplicateButton_Click(object sender, EventArgs e)
        {
            string sourceDir = sourceDirTextBox.Text;
            string destinationDir = destinationDirTextBox.Text;

            try
            {
                if (!Directory.Exists(sourceDir) || !Directory.Exists(destinationDir))
                {
                    MessageBox.Show("Source or destination directory does not exist.");
                    return;
                }

                 _comparisonResults = _repository.CompareAndReplicateDirectories(sourceDir, destinationDir, doNotDeleteCheckBox.Checked);

                // Display the results and update the progress bar
                DisplayComparisonResults();
                UpdateProgressBar();
                // Write logs
                WriteLogs(_comparisonResults);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during comparison and replication: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayComparisonResults()
        {
            try
            {
                // Clear existing rows and columns in the DataGridView
                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();

                // Add columns to the DataGridView
                dataGridView.Columns.Add("FilePathColumn", "File Path");
                dataGridView.Columns.Add("ResultColumn", "Comparison Result");

                // Set AutoGenerateColumns to false to manually add columns
                dataGridView.AutoGenerateColumns = false;

                // Bind columns to properties of the FileComparisonResult class
                dataGridView.Columns["FilePathColumn"].DataPropertyName = "FilePath";
                dataGridView.Columns["ResultColumn"].DataPropertyName = "Result";

                // Add rows for each comparison result
                foreach (var result in _comparisonResults)
                {
                    dataGridView.Rows.Add(result.FilePath, result.Result.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while displaying comparison results: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProgressBar()
        {
            // Calculate the progress and update the progress bar
            int totalFiles = _comparisonResults.Count;
            int completedFiles = _comparisonResults.FindAll(r => r.Result != ComparisonResult.Different).Count;
            int progressPercentage = (int)(((double)completedFiles / totalFiles) * 100);

            replicationProgressBar.Value = progressPercentage;
        }

        private void WriteLogs(List<FileComparisonResult> comparisonResults)
        {
            try
            {
                string logFilePath = "log.txt";

                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"Comparison Results - {DateTime.Now}");
                    foreach (var result in comparisonResults)
                    {
                        writer.WriteLine($"File: {result.FilePath}, Result: {result.Result}");
                    }
                    writer.WriteLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while writing logs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewLogsButton_Click(object sender, EventArgs e)
        {
            try
            {
                string logFilePath = "log.txt";

                // Check if the log file exists
                if (!File.Exists(logFilePath))
                {
                    MessageBox.Show("Log file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Open the log file in Notepad
                System.Diagnostics.Process.Start("notepad.exe", logFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to view logs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
  }

