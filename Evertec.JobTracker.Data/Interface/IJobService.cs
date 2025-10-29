using Evertec.JobTracker.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evertec.JobTracker.Data.Interface
{
    public interface IJobService
    {
        Task<List<Job>> GetAllAsync();
        Task<Job?> GetByIdAsync(int id);
        Task<int> CreateAsync(Job p);
        Task<string> AdvanceToNextStatusAsync(int jobId);
        Task SetExceptionStatusAsync(int jobId, string note);
    }
}
