using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMWFILESYSTEM.Models
{
    public class FileComparisonResult
    {
        public string FilePath { get; set; }
        public ComparisonResult Result { get; set; }
    }

    public enum ComparisonResult
    {
        Identical,
        Different,
        OnlyInSource,
        OnlyInDestination
    }
}