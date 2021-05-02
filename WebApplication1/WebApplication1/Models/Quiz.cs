using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.Models
{
    public class Quiz
    {
        public int rightAnswersCount { get; set; } = 0;
        public int answersCount { get; set; } = 0;
        public List<string> Results { get; set; } = new List<string>();
    }
}
