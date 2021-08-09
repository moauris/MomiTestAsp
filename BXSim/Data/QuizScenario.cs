using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BXSim.Data
{
    public class QuizScenario
    {
        [Column("id")]
        public int QuizScenarioID { get; set; }
        public string PageText { get; set; }
        public virtual IEnumerable<Quiz> Quizzes { get; set; }
    }
}
