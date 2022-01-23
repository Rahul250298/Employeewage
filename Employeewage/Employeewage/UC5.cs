using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    internal class Employee3
    {
        public static void EmployeewageUc4()
        {
            Random random = new Random();
            int fullTimeEmployee = 1;
            int partTimeEmployee = 2;
            int randomInput = random.Next(0, 3);
            int empRateHr = 20;
            int empHrs = 0;
            int totalwage = 0;
            
    
            switch (randomInput)
            {
                case 1:
                    Console.WriteLine("Employee is present:fullTimeEmployee");
                    empHrs = 8;
                    break;
                case 2: 
                     Console.WriteLine("EmplOyee is present:PartTimeEmployee");
                     empHrs = 4;
                     break;
                default :
                      Console.WriteLine("Employee is absent");
                      empHrs = 0;
                      break;
                }
            totalwage = empRateHr * empHrs;
            Console.WriteLine("daily Wage is:" + totalwage);

        }
    }
}


