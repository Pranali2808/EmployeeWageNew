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
            Console.ReadLine();
            
        }
    }
}
