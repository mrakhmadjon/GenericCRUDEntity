using GenericCRUDEntity.Data.Contexts;
using GenericCRUDEntity.Data.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericCRUDEntity.Data
{
    #pragma warning disable
    internal class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private StudentDbContext studentDbContext;

        private DbSet<T> dbSet { get; set; }
        public GenericRepository()
        {
            studentDbContext = new StudentDbContext();
            dbSet = this.studentDbContext.Set<T>();
        }





        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await dbSet.FirstOrDefaultAsync(predicate);
        }


        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            Expression<Func<T, bool>> pred = p => true;
            return dbSet.Where(predicate ?? pred);
        }

        public async Task<T> CreateAsync(T entity)
        {
           EntityEntry entityEntry =  dbSet.Add(entity);
            await studentDbContext.SaveChangesAsync();

            return (T) entityEntry.Entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {

           // studentDbContext.Entry(entity).State = EntityState.Modified;

            studentDbContext.Update(entity);

           await studentDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            var entity = await dbSet.FirstOrDefaultAsync(predicate);
            if (entity is null)
                return false;

            dbSet.Remove(entity);

            await studentDbContext.SaveChangesAsync();
            return true;
        }
    }
}
