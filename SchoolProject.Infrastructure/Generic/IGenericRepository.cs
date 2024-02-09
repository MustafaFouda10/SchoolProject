using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrastructure.Generic
{
    public interface IGenericRepositoryAsync<T> where T : class
    {
        //Task<List<T>> GetAllAsync();
        //Task<T> GetByIdAsync(int id);
        //Task<T> CreateAsync(T entity);
        //Task<T> UpdateAsync(T entity , int id);
        //Task<bool> DeleteAsync(int id);
        
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetTableAsTracking();
        IQueryable<T> GetTableNoTracking();
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(ICollection<T> entities);
        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(ICollection<T> entities);
        Task DeleteAsync(T entity);
        Task DeleteRangeAsync(ICollection<T> entities);
        Task SaveChangesAsync();
        IDbContextTransaction BeginTransaction();
        void Commit();
        void RollBack();

    }
}
