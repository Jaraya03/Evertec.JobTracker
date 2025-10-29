using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evertec.JobTracker.Data.Model
{
    public class Job
    {
        public int Id { get; set; }
        public string ClientName { get; set; } = string.Empty;
        public string JobName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public string Carrier { get; set; } = string.Empty;
        public string CurrentStatus { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime SLA_MailBy { get; set; }

    }
}
