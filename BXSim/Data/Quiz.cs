using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BXSim.Data
{
    public class Quiz
    {
        public int QuizID { get; set; }
        public string Statement { get; set; }
        public string StatementPartial { get; set; }
        public IEnumerable<string> Answers { get; set; }
        public IEnumerable<string> Options { get; set; }
        public string Explanation { get; set; }
    }
}
