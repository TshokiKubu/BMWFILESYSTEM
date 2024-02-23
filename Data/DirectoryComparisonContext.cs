using BMWFILESYSTEM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMWFILESYSTEM.Data
{
    public class DirectoryComparisonContext : DbContext
    {
        public DbSet<FileComparisonResult> FileComparisonResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the database connection string
            optionsBuilder.UseSqlServer("your_connection_string_here");
        }
    }
}