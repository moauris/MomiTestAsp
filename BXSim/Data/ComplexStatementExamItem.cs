using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BXSim.Data
{
    public class ComplexStatementExamItem : IExamItem
    {
        public int Id { get => Statement.GetHashCode(); }
        public IEnumerable<(HtmlTag, string)> Statement { get; set; }
        public IEnumerable<string> Options { get; set; } = new string[] { "Yes", "No" };
        public string Answer { get; set; }
        public string AnswerProvided { get; set; }
        public string Explanation { get; set; }
        public bool Check() => AnswerProvided != null && Answer == AnswerProvided;
    }

    public enum HtmlTag
    {
        div = 0,
        p = 1,
        code = 2
    }
}
