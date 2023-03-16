using Application.DTOs;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Interfaces.Repositories;
using Domain.Models;

namespace Application.Services.Service;

public class SeniorityService : ISeniorityService
{
    private readonly IGenericRepository<Seniority> _repository;
    private readonly IMapper _mapper;

    public SeniorityService(IGenericRepository<Seniority> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<SeniorityDto> CreateAsync(SeniorityDto seniorityDto)
    {
        var seniority = _mapper.Map<Seniority>(seniorityDto);

        await _repository.CreateAsync(seniority);

        seniorityDto = _mapper.Map<SeniorityDto>(seniority);

        return seniorityDto;
    }

    public async Task DeleteAsync(int id)
    {
        var seniorityBd = await _repository.GetByIdAsync(id);

        await _repository.DeleteAsync(seniorityBd);
    }

    public async Task<SeniorityDto> GetByIdAsync(int id)
    {
        var seniorityBd = await _repository.GetByIdAsync(id);
        var seniority = _mapper.Map<SeniorityDto>(seniorityBd);

        return seniority;
    }

    public async Task<ICollection<SeniorityDto>> GetSeniorityAsync()
    {
        var senioritiesDb = await _repository.GetSeniorityAsync();
        var seniorities = _mapper.Map<ICollection<SeniorityDto>>(senioritiesDb);

        return seniorities;
    }

    public async Task UpdateAsync(SeniorityDto seniorityDto)
    {
        var seniority = _mapper.Map<Seniority>(seniorityDto);
        await _repository.UpdateAsync(seniority);
    }
}
