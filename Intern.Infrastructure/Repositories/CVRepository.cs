using Intern.Domain.Entities;
using InternIngressInternal.Intern.Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Intern.Application.Service;

namespace InternIngressInternal.Intern.Infrastructure.Repositories
{
    public class CVRepository:ICVRepository

    {
        private readonly ApplicationDBContext _context;

        public CVRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CV>> GetCVsAsync()
        {
            return await _context.CVs.ToListAsync();
        }

        public async  Task<CV>GetByIdAsync(int ResumeCVid)
        {
            return await _context.CVs.FindAsync(ResumeCVid);
        }
        public async Task<CV> AddAsync(CV cv)
        {
            _context.CVs.Add(cv);
            await _context.SaveChangesAsync();
            return cv;
        }
        public async Task<CV> UpdateAsync(CV cv)
        {
            _context.Entry(cv).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return cv;
        }
        public async Task<CV> DeleteAsync(int ResumeCVid)
        {
            var cv = await _context.CVs.FindAsync(ResumeCVid);
            if (cv == null)
            {
                return null;
            }
            _context.CVs.Remove(cv);
            await _context.SaveChangesAsync();
            return cv;
        }
    }                               
}
