using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace InfraStructure.Context;

public class RecruitmentContext : DbContext, IDisposable
{
    public RecruitmentContext(DbContextOptions<RecruitmentContext> options) : base(options)
    {
    }
    public DbSet<Seniority> Seniorities { get; set; }   
}
