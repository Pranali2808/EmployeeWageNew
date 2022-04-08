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
            //UC1
            //Attendance.GetEmpAttendance();
            //UC2
            //DailyWage.GetDailyWage();
            //UC3
            //PartTimeWage.PartTimeEmpWage();
            //UC4
            //SwitchCase.DailyEmpWage();
            //UC5
            //WageMonth.MonthlyEmpWage();
            //UC6
            //WageTillCondition.GetWageTillCondition();
            //UC7
            //RefactorMethod.RefactorMonthlyEmpWage();
            //UC8
            //MultipleCompany.MultiEmpWage("Google", 11, 3, 15);
            //MultipleCompany.MultiEmpWage("DMart", 20, 2, 10);
            //MultipleCompany.MultiEmpWage("Reliance", 10, 4, 20);
            //UC9
            //empWageBuilder.addCompanyEmpWage("Google", 20, 20, 100);
            //empWageBuilder.addCompanyEmpWage("DMart", 30, 24, 160);
            //empWageBuilder.addCompanyEmpWage("Reliance", 30, 24, 160);
            //empWageBuilder.computeEmpWage();
            // UC10
            //EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            //empWageBuilder.AddCompanyEmpWage("Google", 10, 4, 20);
            //empWageBuilder.AddCompanyEmpWage("Microsoft", 20, 5, 20);
            //empWageBuilder.AddCompanyEmpWage("Deloitte", 30, 3, 30);
            //empWageBuilder.ComputeEmpWage();
            //UC11
            //EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            //empWageBuilder.AddCompanyEmpWage("Google", 10, 4, 20);
            //empWageBuilder.AddCompanyEmpWage("Microsoft", 20, 5, 20);
            //empWageBuilder.AddCompanyEmpWage("Deloitte", 30, 3, 30);
            //empWageBuilder.ComputeEmpWage();
            //UC-12 
            //EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            //empWageBuilder.AddCompanyEmpWage("Google", 10, 4, 20);
            //empWageBuilder.AddCompanyEmpWage("Microsoft", 20, 5, 20);
            //empWageBuilder.AddCompanyEmpWage("Deloitte", 30, 3, 30);
            //empWageBuilder.ComputeEmpWage();
            //UC-13 
            //EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            //empWageBuilder.AddCompanyEmpWageToList("Google", 10, 4, 20);
            //empWageBuilder.AddCompanyEmpWageToList("Microsoft", 20, 5, 20);
            //empWageBuilder.AddCompanyEmpWageToList("Deloitte", 30, 3, 30);
            //empWageBuilder.ComputeEmpWage();
            //UC-14 
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.AddCompanyEmpWageToList("Google", 10, 4, 20);
            empWageBuilder.AddCompanyEmpWageToList("Microsoft", 20, 5, 20);
            empWageBuilder.AddCompanyEmpWageToList("Deloitte", 30, 3, 30);
            empWageBuilder.ComputeEmpWage();
            Console.ReadLine();
            
        }
    }
}
