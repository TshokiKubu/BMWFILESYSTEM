using BMWFILESYSTEM.Repositoy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMWFILESYSTEM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           //--- was Application.Run(new Form1());

            // Create an instance of your repository implementation
            IDirectoryComparisonRepository repository = new DirectoryComparisonRepository(); // Replace with your actual implementation

            // Pass the repository instance to the constructor of Form1
            Application.Run(new Form1(repository));
        }
    }
}
