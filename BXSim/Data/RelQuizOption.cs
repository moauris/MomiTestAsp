using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BXSim.Data
{
    public class RelQuizOption
    {
        public int id { get; set; }

        public int QuizID { get; set; }
        public virtual Quiz Quiz { get; set; }
        public int OptionID { get; set; }
        public virtual Option Option {get; set;}
        public short AnswerState { get; set; }
    }
}
