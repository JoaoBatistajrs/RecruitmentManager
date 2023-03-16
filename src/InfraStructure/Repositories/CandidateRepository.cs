using Domain.Common;
using Domain.Interfaces.Repositories;
using Domain.Models;
using InfraStructure.Context;
using Microsoft.EntityFrameworkCore;

namespace InfraStructure.Repositories
{
    public class CandidateRepository : IGenericRepository<Candidate>
    {

        public readonly RecruitmentContext _context;

        public CandidateRepository(RecruitmentContext context)
        {
            _context = context;
        }

        public async Task<Candidate> CreateAsync(Candidate candidate)
        {
            _context.Add(candidate);
            await _context.SaveChangesAsync();

            return candidate;
        }

        public async Task DeleteAsync(Candidate candidate)
        {
            _context.Remove(candidate);
            await _context.SaveChangesAsync();
        }

        public async Task<Candidate> GetByIdAsync(int id)
        {
            var candidate = await _context.Candidates.FindAsync(id);

            if (candidate == null)
                throw new NotFoundObject("Objetct ID {id} not found.");

            return candidate;
        }

        public async Task<ICollection<Candidate>> GetSeniorityAsync()
        {
            return await _context.Candidates.ToListAsync();
        }

        public async Task UpdateAsync(Candidate candidate)
        {
            _context.Update(candidate);
            await _context.SaveChangesAsync();
        }
    }
}
