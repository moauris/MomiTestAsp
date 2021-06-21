using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BXSim.Data
{
    public class QuizScenario
    {
        public int QuizScenarioID { get; set; }
        public string ScenarioPartial { get; set; }
        public virtual IEnumerable<Quiz> Quizzes { get; set; }
    }
}
