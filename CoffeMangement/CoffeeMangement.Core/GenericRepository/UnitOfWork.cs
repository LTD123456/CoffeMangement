using CoffeeMangement.Data.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMangement.Core.GenericRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        private CoffeeDBContext _context { get; }

        public UnitOfWork(CoffeeDBContext dbContext)
        {
            _context = dbContext;
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public void saveChanges()
        {
            _context.SaveChanges();
        }
    }
}
