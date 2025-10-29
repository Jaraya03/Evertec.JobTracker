using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evertec.JobTracker.Data
{
    public static class QueryableExtensions
    {
        public static IEnumerable<T> OrderByDynamic<T>(this IEnumerable<T> source, string property, bool asc)
        {
            var prop = typeof(T).GetProperty(property);
            if (prop is null) return source;
            return asc
                ? source.OrderBy(x => prop.GetValue(x, null))
                : source.OrderByDescending(x => prop.GetValue(x, null));
        }
    }
}
