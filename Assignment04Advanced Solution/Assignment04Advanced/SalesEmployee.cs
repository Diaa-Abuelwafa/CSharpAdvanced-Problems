using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04Advanced
{
    class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }
        bool Flag = false;

        public SalesPerson(int id)
        {
            EmployeeID = id;
        }
        public bool CheckTarget(int Quota)
        {
            if(Quota == AchievedTarget)
            {
                Flag = true;
                return true;
            }

            return false;
        }

        public override event EventHandler<EmployeeLayOffEventArgs>? EmployeeLayOff;

        public override void EndOfYearOperation()
        {
            if(Flag == false)
            {
                EmployeeLayOff?.Invoke(this, new EmployeeLayOffEventArgs(3));
            }
        }

        public override string ToString()
        {
            return $"Sales Employee ID {EmployeeID}";
        }
    }
}
