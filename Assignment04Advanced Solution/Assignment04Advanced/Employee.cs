using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04Advanced
{
    class Employee
    {
        // Event
        public virtual event EventHandler<EmployeeLayOffEventArgs>? EmployeeLayOff;

        protected virtual void OnEmployeeLayOff (EmployeeLayOffEventArgs e)
        {
            
        }
        public int EmployeeID { get; set; }
        public DateTime BirthDate { get; set; }
        public int VacationStock { get; set; }

        public int checkAge()
        {
            DateTime Now = DateTime.Now;
            int Diff = Now.Year - BirthDate.Year;

            return Diff;
        }

        public bool RequestVacation(DateTime From, DateTime To)
        {
            TimeSpan Diff = To - From;

            if(Diff.Days <= VacationStock)
            {
                VacationStock -= Diff.Days;
                return true;
            }

            return false;
        }
        public virtual void EndOfYearOperation()
        {
            if(VacationStock < 0)
            {
                EmployeeLayOff?.Invoke(this, new EmployeeLayOffEventArgs(1));
            }
            else if (checkAge() > 60)
            {
                EmployeeLayOff?.Invoke(this, new EmployeeLayOffEventArgs(2));
            }
        }

        public override string ToString()
        {
            return $"Employee ID {EmployeeID}";
        }
    }
    public enum LayOffCause
    {
        VacationNegative,
        MoreThan60,
        NoTarget,
        Resign
    }
    public class EmployeeLayOffEventArgs
    {
        public LayOffCause Cause { get; set; }

        public EmployeeLayOffEventArgs(int n)
        {
            if(n == 1)
            {
                Cause = LayOffCause.VacationNegative;
            }
            else if(n == 2)
            {
                Cause = LayOffCause.MoreThan60;
            }
            else if(n == 3)
            {
                Cause = LayOffCause.NoTarget;
            }
            else
            {
                Cause = LayOffCause.Resign;
            }
        }
    }
}
