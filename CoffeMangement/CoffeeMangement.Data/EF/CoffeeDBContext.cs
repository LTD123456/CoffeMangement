using CoffeeMangement.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMangement.Data.EF
{
    public class CoffeeDBContext : DbContext
    {
        public CoffeeDBContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>().HasKey(k => k.ID);
            modelBuilder.Entity<BillInfo>().HasKey(k => k.ID);
            modelBuilder.Entity<Food>().HasKey(k => k.ID);
            modelBuilder.Entity<FoodCategory>().HasKey(k => k.ID);
            modelBuilder.Entity<TableFood>().HasKey(k => k.ID);
            modelBuilder.Entity<User>().HasKey(k => k.ID);
        }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillInfo> BillInfos { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodCategory> FoodCategorys { get; set; }
        public DbSet<TableFood> TableFoods { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
