using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17Extry.ShopResources
{
    public class ShopDBContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Label> Labels { get; set; }

        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Category> Categories { get; set; }
        /// <summary>
        /// EXPLICATI LA MANY TO MANY HOW U DO IT 
        /// </summary>
        public DbSet<Dictionary<int, Object>> CategoryManufacturer => Set<Dictionary<int,object>>("CategoryManufacturer");
        public ShopDBContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\illei\source\repos\Laboratorul 17\Lab17Ex\Lab17Extry\Lab17Extry\ShopDB.mdf"";Integrated Security=True");
        }
    }
}
