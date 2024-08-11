using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04Advanced
{
    class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        List<Employee> Staff;

        public Department(int id, string name)
        {
            this.DeptID = id;
            this.DeptName = name;
        }
        public void AddStaff(Employee E)
        {
            if(E.checkAge() < 60)
            {
                Staff.Add(E);
            }
            else
            {
                Console.WriteLine("This Employee Cannot Add To The Department");
            }
        }
        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.VacationNegative || e.Cause == LayOffCause.MoreThan60)
            {
                Console.WriteLine($"Department Removed This {this} From Department {DeptName} Staff");
            }
        }
    }
}
