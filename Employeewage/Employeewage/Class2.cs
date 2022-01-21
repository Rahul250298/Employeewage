using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    internal class Employee1
    {
        public static void EmployeewageUc2()
        {
            Random random = new Random();
            int fullTimeEmployee = 1;
            int randomInput = random.Next(0, 2);
            int empRateHr = 40;
            int empHrs = 0;
            int totalwage = 0;

            if (randomInput == fullTimeEmployee)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }
            totalwage = empRateHr * empHrs;
            Console.WriteLine("daily Wage is:" + totalwage);
            
        }
    }
}