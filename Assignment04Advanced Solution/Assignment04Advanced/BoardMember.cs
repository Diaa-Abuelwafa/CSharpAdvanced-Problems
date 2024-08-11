using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04Advanced
{
    class BoardMember : Employee
    {
        bool Flag = true;
        public void Resign()
        {
            Flag = false;
        }

        public BoardMember (int id)
        {
            EmployeeID = id;
        }

        public override event EventHandler<EmployeeLayOffEventArgs>? EmployeeLayOff;
        public override void EndOfYearOperation()
        {
            if (Flag == false)
            {
                EmployeeLayOff?.Invoke(this, new EmployeeLayOffEventArgs(4));
            }
        }

        public override string ToString()
        {
            return $"Board Mmber ID {EmployeeID}";
        }
    }
}
