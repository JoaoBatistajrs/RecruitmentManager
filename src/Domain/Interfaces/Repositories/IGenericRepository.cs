using Domain.Models;

namespace Domain.Interfaces.Repositories;


public interface IGenericRepository<TEntity> where TEntity : class
{
    Task<ICollection<TEntity>> GetSeniorityAsync();
    Task<TEntity> GetByIdAsync(int id);
    Task<TEntity> CreateAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
}
 