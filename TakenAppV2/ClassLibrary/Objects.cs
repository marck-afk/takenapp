using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Tasks
    {
        public int id { get; set; }
        public string subject { get; set; }
        public int priorety { get; set; }
        public string state { get; set; }
        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }
    }
}
