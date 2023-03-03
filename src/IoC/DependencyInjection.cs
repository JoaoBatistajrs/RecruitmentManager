﻿using Application.Services.Interfaces;
using Application.Services.Service;
using Domain.Interfaces.Repositories;
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
        services.AddDbContext<RecruitmentContext>(options => options.UseSqlServer(configuration.GetConnectionString("")));
        services.AddScoped<ISeniorityRepository, SeniorityRepository>();

        return services;
    }
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        //services.AddAutoMapper(typeof(DomainToDtoMapping));
        services.AddScoped<ISeniorityService, SeniorityService>();

        return services;
    }
}
