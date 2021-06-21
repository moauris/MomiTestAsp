using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BXSim.Data
{
    public interface IExamRepo
    {
        public List<IExamItem> Questions { get; }
        public IEnumerable<QuizScenario> Scenarios { get; }
    }
}
