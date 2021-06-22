using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BXSim.Extensions
{
    public static class ListExtensions
    {
        public static IEnumerable<T> ShuffleItems<T>(this IEnumerable<T> list)
        {
            if (list.Count() == 2)
            {
                return list;
            }
            Random r = new Random();
            return list.OrderBy(x => r.Next());
        }

    }
}
