using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMWFILESYSTEM.Models;

namespace BMWFILESYSTEM.Repositoy
{
    public class DirectoryComparisonRepository : IDirectoryComparisonRepository
    {

        public List<FileComparisonResult> CompareAndReplicateDirectories(string sourceDir, string destinationDir, bool doNotDelete)
        {
            List<FileComparisonResult> results = new List<FileComparisonResult>();

            try
            {
                CompareDirectories(sourceDir, destinationDir, results, doNotDelete);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return results;
        }

        private void CompareDirectories(string sourceDir, string destinationDir, List<FileComparisonResult> results, bool doNotDelete)
        {
            // Compare files in source and destination directories
            CompareFilesInDirectory(sourceDir, destinationDir, results);

            // Recursively compare subdirectories
            foreach (string subDir in Directory.GetDirectories(sourceDir))
            {
                string subDirName = Path.GetFileName(subDir);
                string destSubDir = Path.Combine(destinationDir, subDirName);

                if (!Directory.Exists(destSubDir))
                {
                    Directory.CreateDirectory(destSubDir);
                    results.Add(new FileComparisonResult { FilePath = destSubDir, Result = ComparisonResult.OnlyInSource });
                }

                CompareDirectories(subDir, destSubDir, results, doNotDelete);
            }

            // Delete files and directories in destination not found in source
            if (!doNotDelete)
            {
                DeleteExtraFilesAndDirectories(sourceDir, destinationDir, results);
            }
        }

        private void CompareFilesInDirectory(string sourceDir, string destinationDir, List<FileComparisonResult> results)
        {
            foreach (string sourceFile in Directory.GetFiles(sourceDir))
            {
                string relativePath = sourceFile.Substring(sourceDir.Length + 1);
                string destFile = Path.Combine(destinationDir, relativePath);

                if (!File.Exists(destFile))
                {
                    File.Copy(sourceFile, destFile);
                    results.Add(new FileComparisonResult { FilePath = destFile, Result = ComparisonResult.OnlyInSource });
                }
                else
                {
                    FileInfo sourceFileInfo = new FileInfo(sourceFile);
                    FileInfo destFileInfo = new FileInfo(destFile);

                    if (sourceFileInfo.Length != destFileInfo.Length ||
                        sourceFileInfo.LastWriteTimeUtc > destFileInfo.LastWriteTimeUtc)
                    {
                        File.Copy(sourceFile, destFile, true);
                        results.Add(new FileComparisonResult { FilePath = destFile, Result = ComparisonResult.Different });
                    }
                    else
                    {
                        results.Add(new FileComparisonResult { FilePath = destFile, Result = ComparisonResult.Identical });
                    }
                }
            }
        }

        private void DeleteExtraFilesAndDirectories(string sourceDir, string destinationDir, List<FileComparisonResult> results)
        {
            foreach (string destFile in Directory.GetFiles(destinationDir))
            {
                string relativePath = destFile.Substring(destinationDir.Length + 1);
                string sourceFile = Path.Combine(sourceDir, relativePath);

                if (!File.Exists(sourceFile))
                {
                    File.Delete(destFile);
                    results.Add(new FileComparisonResult { FilePath = destFile, Result = ComparisonResult.OnlyInDestination });
                }
            }

            foreach (string destSubDir in Directory.GetDirectories(destinationDir))
            {
                string subDirName = Path.GetFileName(destSubDir);
                string sourceSubDir = Path.Combine(sourceDir, subDirName);

                if (!Directory.Exists(sourceSubDir))
                {
                    Directory.Delete(destSubDir, true);
                    results.Add(new FileComparisonResult { FilePath = destSubDir, Result = ComparisonResult.OnlyInDestination });
                }
            }
        }
    }
}