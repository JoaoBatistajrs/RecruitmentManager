using Application.DTOs;

namespace Application.Services.Interfaces
{
    public interface ICandidateService
    {
        Task<ICollection<CandidateDto>> GetSeniorityAsync();
        Task<CandidateDto> GetByIdAsync(int id);
        Task<CandidateDto> CreateAsync(CandidateDto candidateDto);
        Task UpdateAsync(CandidateDto candidateDto);
        Task DeleteAsync(int id);
    }
}
