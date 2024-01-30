using clase11_codefirst.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase11_codefirst.database
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=Coder29012024; Trusted_Connection=True;");
        }
    }
}
