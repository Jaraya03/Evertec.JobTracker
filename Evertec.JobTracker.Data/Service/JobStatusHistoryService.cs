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
    public class JobStatusHistoryService : IJobStatusHistoryService
    {
        private readonly AppDbContext _db;
        public JobStatusHistoryService(AppDbContext db) => _db = db;

        public async Task<int> CreateAsync(JobStatusHistory p)
        {
            _db.JobStatusHistory.Add(p);
            await _db.SaveChangesAsync();
            return p.Id;
        }

        public Task<List<JobStatusHistory>> GetAllAsync()
        {
            return _db.JobStatusHistory.AsNoTracking().OrderByDescending(p => p.ChangedAt).ToListAsync();
        }

        public Task<List<JobStatusHistory>> GetByJobIdAsync(int jobId)
        {
            return _db.JobStatusHistory
             .AsNoTracking()
             .Where(h => h.JobId == jobId)
             .OrderByDescending(h => h.ChangedAt)
             .ToListAsync();
        }
    }
}
