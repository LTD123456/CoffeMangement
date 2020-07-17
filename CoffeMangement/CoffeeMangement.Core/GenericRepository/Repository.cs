using CoffeeMangement.Data.EF;
using CoffeeMangement.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMangement.Core.GenericRepository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private DbSet<T> _dbset;
        string errorMessage = string.Empty;
        public Repository(CoffeeDBContext context)
        {
            this._dbset = context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbset.Add(entity);
        }

        public void AddRange(IEnumerable<T> lstEntity)
        {
            _dbset.AddRange(lstEntity);
        }

        public void Delete(T entity)
        {
            _dbset.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbset.AsEnumerable();
        }

        public T GetByKey (Guid? id)
        {
            return _dbset.SingleOrDefault(s => s.ID == id);
        }

        public void Update(T entity)
        {
            this._dbset.Update(entity);
        }
        
    }
}
