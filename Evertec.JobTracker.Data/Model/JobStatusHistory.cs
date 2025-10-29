using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evertec.JobTracker.Data.Model
{
    public class JobStatusHistory
    {
        public int Id { get; set; }
        public int JobId { get; set; }     // FK
        public string Status { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public DateTime ChangedAt { get; set; }
    }
}
