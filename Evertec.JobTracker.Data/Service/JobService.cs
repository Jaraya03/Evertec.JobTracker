using Evertec.JobTracker.Data.Interface;
using Evertec.JobTracker.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evertec.JobTracker.Data.Service
{
    public class JobService : IJobService
    {
        public readonly AppDbContext _db;
        public JobService (AppDbContext db) => _db = db;
        public async Task<int> CreateAsync(Job p)
        {
            _db.Jobs.Add(p);
            await _db.SaveChangesAsync();
            return p.Id;
        }

        public Task<List<Job>> GetAllAsync()
        {
            return _db.Jobs.AsNoTracking().OrderByDescending(p => p.CreatedAt).ToListAsync();
        }

        public Task<Job?> GetByIdAsync(int id)
        {
            return _db.Jobs.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
