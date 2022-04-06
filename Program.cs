using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Empolyee Wage Computation Program\n");
            Attendance.GetEmpAttendance();
            DailyWage.GetDailyWage();
            PartTimeWage.PartTimeEmpWage();
            SwitchCase.DailyEmpWage();
            WageMonth.MonthlyEmpWage();
            WageTillCondition.GetWageTillCondition();
            RefactorMethod.RefactorMonthlyEmpWage();
            MultipleCompany.MultiEmpWage("Google",11,3,15 );
            MultipleCompany.MultiEmpWage("DMart", 20, 2, 10);
            MultipleCompany.MultiEmpWage("Reliance", 10, 4, 20);
            Console.ReadLine();
            
        }
    }
}
