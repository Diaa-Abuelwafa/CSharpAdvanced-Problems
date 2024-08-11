using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04Advanced
{
    class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        List<Employee> Members;
        public void AddMember(Employee E)
        {
            Members.Add(E);
        }

        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.VacationNegative)
            {
                Console.WriteLine($"Club Removed This {this} From Club Members");
            }
        }
    }
}
