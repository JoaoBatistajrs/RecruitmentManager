using Application.DTOs;
using AutoMapper;
using Domain.Models;

namespace Application.Mapper;

public class DomainToDtoMapping : Profile
{
    public DomainToDtoMapping()
    {
        CreateMap<Seniority, SeniorityDto>();
        CreateMap<Candidate, CandidateDto>();
    }
}
