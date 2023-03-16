using Domain.Common;
using Domain.Interfaces.Repositories;
using Domain.Models;
using InfraStructure.Context;
using Microsoft.EntityFrameworkCore;

namespace InfraStructure.Repositories
{
    public class SeniorityRepository : IGenericRepository<Seniority>
    {
        public readonly RecruitmentContext _context;

        public SeniorityRepository(RecruitmentContext context)
        {
            _context = context;
        }

        public async Task<Seniority> CreateAsync(Seniority seniority)
        {
            _context.Add(seniority);
            await _context.SaveChangesAsync();

            return seniority;
        }

        public async Task DeleteAsync(Seniority seniority)
        {
            _context.Remove(seniority);
            await _context.SaveChangesAsync();
        }

        public async Task<Seniority> GetByIdAsync(int id)
        {
            var seniority = await _context.Seniorities.FindAsync(id);

            if (seniority == null)
                throw new NotFoundObject("Objetct ID {id} not found.");

            return seniority;
        }

        public async Task<ICollection<Seniority>> GetSeniorityAsync()
        {
            return await _context.Seniorities.ToListAsync();
        }

        public async Task UpdateAsync(Seniority seniority)
        {
            _context.Update(seniority);
            await _context.SaveChangesAsync();
        }
    }
}
