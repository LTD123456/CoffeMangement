using CoffeeMangement.Data.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMangement.Core.GenericRepository
{
    interface IRepository<T> where T : BaseEntity
    {
        void Add(T entity);
        void Update(T entity);
        void AddRange(IEnumerable<T> lstEntity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        T GetByKey(Guid? id);
    }
}
