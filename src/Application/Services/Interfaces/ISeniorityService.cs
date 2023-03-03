using Application.DTOs;

namespace Application.Services.Interfaces;

public interface ISeniorityService
{
    Task<ICollection<SeniorityDto>> GetSeniorityAsync();
    Task<SeniorityDto> GetByIdAsync(int id);
    Task<SeniorityDto> CreateAsync(SeniorityDto seniorityDto);
    Task UpdateAsync(SeniorityDto seniorityDto);
    Task DeleteAsync(int id);
}
