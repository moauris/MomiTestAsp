﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BXSim.Data
{
    public class ExamItem : IExamItem
    {
        public ExamItem() { }
        public ExamItem(string state, string ans)
        {
            Statement = state;
            Answer = ans;
        }
        
        public string Statement { get; set; }
        public IEnumerable<string> Options { get; set; } = new string[] { "Yes", "No" };
        public string AnswerProvided { get; set; }

        public int Id => Statement.GetHashCode();

        public string Answer { get; set; }
        public string Explanation { get; set; }

        public bool Check() => AnswerProvided != null && Answer == AnswerProvided;
    }
}
