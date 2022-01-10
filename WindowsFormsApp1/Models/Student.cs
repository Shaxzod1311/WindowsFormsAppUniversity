using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Student
    {
        public string F_name { get ; set; }
        public string S_name { get; set; }
        public string DateOfBith { get; set; }

        public int Course { get; set; } = 1;

        public string Direction { get; set; }

        public bool IsPaidContract { get; set; } = false;

        public string Phone { get; set; }

        public override string ToString()
        {
            return $"{this.F_name}\t{this.S_name}\t{this.DateOfBith}\t{this.Course}\t{this.Direction}\t{this.IsPaidContract}\t{this.Phone}";
        }
    }
}
