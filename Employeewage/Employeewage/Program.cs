using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmployeeWage6 employee = new EmployeeWage6();
            employee.MonthlytEmpwage();
            Console.ReadLine();
        }
    }
}
