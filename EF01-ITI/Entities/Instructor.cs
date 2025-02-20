using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01_ITI.Entities
{
    // Fluent APIS - Class Configuration
    class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Bouns { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public int Houre_Rate { get; set; }
        public int Dept_Id { get; set; }

    }
}
