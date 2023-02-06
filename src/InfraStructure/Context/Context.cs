using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace InfraStructure.Context;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }
    public DbSet<Seniority> Seniorities { get; set; }   
}
