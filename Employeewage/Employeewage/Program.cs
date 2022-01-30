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
            EmployeeWage7 employee = new EmployeeWage7();
            employee.MonthlytEmpwage();
            Console.ReadLine();
        }
    }
}
