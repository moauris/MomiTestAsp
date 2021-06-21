using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace BXSim.Extensions
{
    public static class JsonSerializationExtensions
    {
        public static string ToJsonString(this IEnumerable<string> arr)
        {
            return JsonSerializer.Serialize(arr);
        }

        public static IEnumerable<string> ToIEnumString (this string str)
        {
            return JsonSerializer.Deserialize<IEnumerable<string>>(str);
        }

    }
}
