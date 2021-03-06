using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericCRUDEntity.Data.IRepository
{
    internal interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync (Expression<Func<T, bool>> predicate);

        Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null);

        Task<T> CreateAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate);




    }
}
