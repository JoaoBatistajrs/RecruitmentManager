using Application.Mapper;
using Application.Services.Interfaces;
using Application.Services.Service;
using Domain.Interfaces.Repositories;
using Domain.Models;
using InfraStructure.Context;
using InfraStructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IoC;

public static class DependencyInjection
{
    public static IServiceCollection AddInfraStrucuture(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<RecruitmentContext>(options => options.UseSqlServer(configuration.GetConnectionString("RecruitmentConnectionStrings")));
        services.AddScoped<IGenericRepository<Seniority>, SeniorityRepository>();
        services.AddScoped<IGenericRepository<Candidate>, CandidateRepository>();

        return services;
    }
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAutoMapper(typeof(DomainToDtoMapping));
        services.AddAutoMapper(typeof(DtoToDomainMapping));
        services.AddScoped<ISeniorityService, SeniorityService>();
        services.AddScoped<ICandidateService, CandidateService>();

        return services;
    }
}
