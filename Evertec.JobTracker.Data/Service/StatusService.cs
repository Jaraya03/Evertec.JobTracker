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
    public class StatusService : IStatusService
    {
        private readonly AppDbContext _db;
        public StatusService(AppDbContext db) => _db = db;
        public Task<List<Status>> GetAll()
        {
            return _db.Status.AsNoTracking().ToListAsync();
        }
    }
}
