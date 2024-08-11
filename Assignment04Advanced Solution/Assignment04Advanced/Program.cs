namespace Assignment04Advanced
{
    internal class Program
    {
        public static void Main()
        {
            Employee E01 = new Employee(1);
            SalesPerson E02 = new SalesPerson(2);
            BoardMember E03 = new BoardMember(3);

            E01.BirthDate = new DateTime(1950, 11, 18);
            E01.VacationStock = 15;
            E01.RequestVacation(new DateTime(2024, 11, 18), new DateTime(2024, 11, 22));

            E02.BirthDate = new DateTime(2006, 11, 18);
            E03.BirthDate = new DateTime(1999, 11, 18);

            Company company = new Company();
            company.AddEmployee(E01);
            company.AddEmployee(E02);
            company.AddEmployee(E03);

            Department department = new Department();
            department.AddStaff(E01);
            department.AddStaff(E02);
            department.AddStaff(E03);

            Club club = new Club();
            club.AddMember(E01);
            club.AddMember(E02);
            club.AddMember(E03);

            E01.EmployeeLayOff += company.RemoveStaff;
            E01.EmployeeLayOff += department.RemoveStaff;
            E01.EmployeeLayOff += club.RemoveMember;

            E02.EmployeeLayOff += company.RemoveStaff;
            E02.EmployeeLayOff += department.RemoveStaff;
            E02.EmployeeLayOff += club.RemoveMember;

            E03.EmployeeLayOff += company.RemoveStaff;
            E03.EmployeeLayOff += department.RemoveStaff;
            E03.EmployeeLayOff += club.RemoveMember;

            E01.EndOfYearOperation();
            E02.EndOfYearOperation();
            E03.EndOfYearOperation();
        }
    }
}