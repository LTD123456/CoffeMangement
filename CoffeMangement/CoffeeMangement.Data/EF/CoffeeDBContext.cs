using CoffeeMangement.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMangement.Data.EF
{
    public class CoffeeDBContext : DbContext
    {
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillInfo> BillInfos { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodCategory> FoodCategorys { get; set; }
        public DbSet<TableFood> TableFoods { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LTHIENDUC\SQLEXPRESS;Database=CoffeeManagement;Trusted_Connection=True;");
        }
    }
}
