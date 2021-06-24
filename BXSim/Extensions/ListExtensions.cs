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

        public static int GetIndex(this IEnumerable<string> list, string input)
        {
            int i = 0;
            foreach (string s in list)
            {
                if (s == input) return i;
                i++;
            }
            return -1;
        }

    }
}
