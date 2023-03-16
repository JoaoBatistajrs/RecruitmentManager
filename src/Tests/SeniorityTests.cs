using Domain.Interfaces.Repositories;
using Domain.Models;
using InfraStructure.Context;
using Moq;

namespace Tests;

public class SeniorityTests
{
    public readonly IGenericRepository<Seniority> _repository;

    public SeniorityTests(IGenericRepository<Seniority> repository)
    {
        _repository = repository;
    }

    [Fact]
    public async Task TestUpdateAsync()
    {

    }
}