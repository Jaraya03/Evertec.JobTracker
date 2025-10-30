using Evertec.JobTracker.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evertec.JobTracker.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Job> Jobs => Set<Job>();
        public DbSet<JobStatusHistory> JobStatusHistory => Set<JobStatusHistory>();
        public DbSet<Status> Status => Set<Status>();
    }
}
