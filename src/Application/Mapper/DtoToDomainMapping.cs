﻿using Application.DTOs;
using AutoMapper;
using Domain.Models;

namespace Application.Mapper;

public class DtoToDomainMapping : Profile
{
    public DtoToDomainMapping()
    {
        CreateMap<SeniorityDto, Seniority>();
        CreateMap<CandidateDto, Candidate>();
    }
}
