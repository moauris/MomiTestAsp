using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BXSim.Data
{
    public class Quiz
    {
        [Column("id")]
        public int QuizID { get; set; }
        public string Question { get; set; }

        public int ScenarioID { get; set; }
        public QuizScenario Scenario { get; set; }
        public virtual IEnumerable<RelQuizOption> RelQuizOptions { get; set; }
    }
}
