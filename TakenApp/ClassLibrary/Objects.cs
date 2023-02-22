using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Task
    {
        public int id { get; set; }
        public string subject { get; set; }
        public int priority { get; set; }
        public string state { get; set; }
        public DateTime date { get; set; }
    }
}
