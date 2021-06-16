using BXSim.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BXSim.Models
{
    public class ExamControllerViewModel
    {
        public IEnumerable<ExamItem> Questions { get; set; }
    }
}
