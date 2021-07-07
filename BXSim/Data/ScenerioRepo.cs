using Microsoft.EntityFrameworkCore;
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
        public IEnumerable<QuizScenario> Scenarios => context.tbl_scenarios;
        public IEnumerable<Quiz> Quizzes => context.tbl_quizzes.Include(q => q.RelQuizOptions).ThenInclude(r => r.Option);
    }
}
