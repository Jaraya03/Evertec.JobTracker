using Evertec.JobTracker.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evertec.JobTracker.Data.Interface
{
    public interface IStatusService
    {
        Task<List<Status>> GetAll();
    }
}
