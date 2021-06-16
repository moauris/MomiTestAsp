using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BXSim.Extensions
{
    public static class ListExtensions
    {
        public static IList<T> ShuffleItems<T>(this IList<T> list)
        {
            Random r = new Random();
            return list.OrderBy(x => r.Next()).ToList();
        }
    }
}
