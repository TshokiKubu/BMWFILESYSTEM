using BMWFILESYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMWFILESYSTEM.Repositoy
{
    public interface IDirectoryComparisonRepository
    {
        List<FileComparisonResult> CompareAndReplicateDirectories(string sourceDir, string destinationDir, bool doNotDelete);

    }
}
