using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BXSim.Data
{
    public class PracticeSet
    {
        public int id {get; set;}
        public string Code { get; set; }
        public string Title { get; set; }
        public string IntroPage { get; set; }
    }
}
