using System.Collections.Generic;

namespace BXSim.Data
{
    public interface IExamItem
    {
        public int Id { get; }
        public string Answer { get; set; }
        public IEnumerable<string> Options { get; set; }
        public string Explanation { get; set; }
        public bool Check();
    }
}