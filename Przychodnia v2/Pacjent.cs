using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia_v2
{
    public class PacjentContext : DbContext
    {
        public DbSet<Pacjent> Pacjents { get; set; }

        public string DbPath { get; }
        
        public PacjentContext() 
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "pacjent05.db");

        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            Console.WriteLine(DbPath);
            // dbContextOptionsBuilder.UseSqlite("Data Source =pacjent04.db");
            dbContextOptionsBuilder.UseSqlite($"Data Source ={DbPath}");
        }

    }
    public class Pacjent 
    {
        public int Id { get; set; }

        public string Name { get; set; }









    }
}

