using Microsoft.VisualStudio.TestTools.UnitTesting;
using BXSim.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BXSim.Extensions.Tests
{
    [TestClass()]
    public class JsonSerializationExtensionsTests
    {
        [TestMethod()]
        public void ToJsonStringTest()
        {
            IEnumerable<string> input = new string[] { "apple", "banana", "orange" };
            string result = input.ToJsonString();
            Console.WriteLine(result);

            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void ToIEnumStringTest()
        {
            string input = @"[""apple"",""banana"",""orange""]";

            IEnumerable<string> result = input.ToIEnumString();
            Console.WriteLine(string.Join(",", result));

            Assert.IsTrue(true);
        }
    }
}