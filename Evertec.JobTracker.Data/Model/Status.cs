using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evertec.JobTracker.Data.Model
{
    public class Status
    {
        [Key]
        public string StatusCode { get; set; }
        public int SortOrder {  get; set; }
        public bool IsTerminal { get; set; }
    }
}
