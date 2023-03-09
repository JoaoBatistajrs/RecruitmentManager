using Domain.Models;

namespace Domain.Interfaces.Repositories;


public interface ISeniorityRepository
{
    Task<ICollection<Seniority>> GetSeniorityAsync();
    Task<Seniority> GetByIdAsync(int id);
    Task<Seniority> CreateAsync(Seniority seniority);
    Task UpdateAsync(Seniority seniority);
    Task DeleteAsync(Seniority seniority);
}
