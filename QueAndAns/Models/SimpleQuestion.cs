using System;
using System.Collections.Generic;

namespace QueAndAns.Models
{
    public class SimpleQuestion
    {
        public string SelectedAnswer { get; set; }
        public string Question { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string RightIs { get; set; }
        public int QuesId { get; set; }
    }
    public class MediumQuestion
    {
        public string Question { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string Answer5 { get; set; }
        public List<string> RightAre { get; set; }
        public List<string> SelectedAre { get; set; }
        public int QuesId { get; set; }
    }
}
