using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public static bool operator ==(Employee E1, Employee E2)
        {
            if(E1.ID == E2.ID && E1.Name == E2.Name && E1.Salary == E2.Salary)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Employee E1, Employee E2)
        {
            if (E1.ID != E2.ID || E1.Name != E2.Name || E1.Salary != E2.Salary)
            {
                return true;
            }

            return false;
        }
    }
}
