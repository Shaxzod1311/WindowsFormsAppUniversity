using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{ 
    public class Teacher
    {
        public string F_name { get; set; }
        public string S_name { get; set; }
        public string DateOfBith { get; set; }

        public double Salary { get; set; }

        public string Subject { get; set; }

        public string Phone { get; set; }

        public override string ToString()
        {
            return $"{this.F_name}\t{this.S_name}\t{this.DateOfBith}\t{this.Subject}\t{this.Salary}\t{this.Phone}";
        }
    }
}
