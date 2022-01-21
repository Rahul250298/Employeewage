using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    internal class Employee2
    {
        public static void EmployeewageUc3()
        {
            Random random = new Random();
            int fullTimeEmployee = 1;
            int partTimeEmployee = 2;
            int randomInput = random.Next(0, 3);
            int empRateHr = 40;
            int empHrs = 0;
            int totalwage = 0;

            if (randomInput == fullTimeEmployee)
            {
                Console.WriteLine("Employee is present:fullTimeEmployee");
                empHrs = 8;
            }
            else if(randomInput == partTimeEmployee)
            {
                Console.WriteLine("emplyee is present:PartTimeEmployee");
                empHrs = 4;
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
