using System;
using System.Collections.Generic;

namespace QueAndAns.Models
{
    public class TestInformation
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<SimpleQuestion> SimpleQuestions { get; set; }
    }
}
