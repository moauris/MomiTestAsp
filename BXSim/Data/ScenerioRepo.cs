using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BXSim.Data
{
    public class ScenerioRepo
    {
        private BXSimDbContext context;
        public ScenerioRepo(BXSimDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<QuizScenario> Scenarios => context.QuizScenarios;
        public IEnumerable<Quiz> Quizzes => context.Quizzes;
    }
}
