using Application.DTOs;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Interfaces.Repositories;
using Domain.Models;

namespace Application.Services.Service;

public class CandidateService : ICandidateService
{

    private readonly IGenericRepository<Candidate> _repository;
    private readonly IMapper _mapper;

    public CandidateService(IGenericRepository<Candidate> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<CandidateDto> CreateAsync(CandidateDto candidateDto)
    {
        var candidate = _mapper.Map<Candidate>(candidateDto);

        await _repository.CreateAsync(candidate);

        candidateDto = _mapper.Map<CandidateDto>(candidate);

        return candidateDto;
    }

    public async Task DeleteAsync(int id)
    {
        var candidateDb = await _repository.GetByIdAsync(id);

        await _repository.DeleteAsync(candidateDb);
    }

    public async Task<CandidateDto> GetByIdAsync(int id)
    {
        var candidateDb = await _repository.GetByIdAsync(id);
        var candidate = _mapper.Map<CandidateDto>(candidateDb);

        return candidate;
    }

    public async Task<ICollection<CandidateDto>> GetSeniorityAsync()
    {
        var candidateDb = await _repository.GetSeniorityAsync();
        var candidates = _mapper.Map<ICollection<CandidateDto>>(candidateDb);

        return candidates;
    }

    public async Task UpdateAsync(CandidateDto candidateDto)
    {
        var candidate = _mapper.Map<Candidate>(candidateDto);
        await _repository.UpdateAsync(candidate);
    }
}