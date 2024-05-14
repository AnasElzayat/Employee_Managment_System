using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveDataObject
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Salary { get; set; }
        public string Sex { get; set; }
        public int DeptId { get; set; }
    }
}
