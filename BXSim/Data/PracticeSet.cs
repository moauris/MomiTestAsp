using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BXSim.Data
{
    public class PracticeSet
    {
        [Column(TypeName = "id")]
        public int PracticeSetID {get; set;}
        public string PracticeName { get; set; }
        public string PracticeIntroPage { get; set; }
    }
}
