using Evertec.JobTracker.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evertec.JobTracker.Data.Interface
{
    public interface IJobStatusHistoryService
    {
        Task<List<JobStatusHistory>> GetAllAsync();
        Task<List<JobStatusHistory>> GetByJobIdAsync(int id);
        Task<int> CreateAsync(JobStatusHistory p);
    }
}
