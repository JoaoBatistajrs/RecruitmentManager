using Domain.Interfaces.Repositories;
using Domain.Models;
using InfraStructure.Context;
using Moq;

namespace Tests;

public class SeniorityTests
{
    public readonly ISeniorityRepository _repository;

    public SeniorityTests(ISeniorityRepository repository)
    {
        _repository = repository;
    }

    [Fact]
    public async Task TestUpdateAsync()
    {

    }
}