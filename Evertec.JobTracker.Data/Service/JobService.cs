using Evertec.JobTracker.Data.Interface;
using Evertec.JobTracker.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evertec.JobTracker.Data.Service
{
    public class JobService : IJobService
    {
        public readonly AppDbContext _db;
        public JobService (AppDbContext db) => _db = db;
        // Imer Instead of creating a store procedure I decide to create a transaction using only EF to follow the first instruction that was using EF to connect to DB
        // and i feel that a transaction is better for this method as its a secuence of Inserts in DB
        public async Task<int> CreateAsync(Job job)
        {
            job.CurrentStatus = string.IsNullOrWhiteSpace(job.CurrentStatus) ? "Received" : job.CurrentStatus.Trim();
            if (job.CreatedAt == default) job.CreatedAt = DateTime.UtcNow;

            using var tx = await _db.Database.BeginTransactionAsync();

            _db.Jobs.Add(job);
            await _db.SaveChangesAsync(); 

            var hist = new JobStatusHistory
            {
                JobId = job.Id,
                Status = job.CurrentStatus,
                Note = "Status automatically set as Received",
                ChangedAt = DateTime.UtcNow
            };
            _db.JobStatusHistory.Add(hist);
            await _db.SaveChangesAsync();

            await tx.CommitAsync();
            return job.Id;
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
