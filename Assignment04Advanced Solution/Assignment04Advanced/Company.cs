using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04Advanced
{
    internal class Company
    {
        List<Employee> Employees;

        public void AddEmployee(Employee E)
        {
            if (E.checkAge() < 60)
            {
                Employees.Add(E);
            }
            else
            {
                Console.WriteLine("This Employee Cannot Add To The Company");
            }
        }

        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            if(e.Cause == LayOffCause.VacationNegative || e.Cause == LayOffCause.MoreThan60 || e.Cause == LayOffCause.NoTarget || e.Cause == LayOffCause.Resign)
            {
                Console.WriteLine($"Company Removed This {this} From Company Staff");
            }
        }
    }
}
