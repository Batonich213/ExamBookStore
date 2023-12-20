using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ExamBookStore
{
    internal class AppContext : DbContext
    {
        public DbSet<User> Users => Set<User>();

        public DbSet<Books> Books => Set<Books>();

        public static object User { get; internal set; }

        public AppContext() =>  Database.EnsureCreated();
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=BookStore; Trusted_Connection = True;");
            }
        }
    }
}
