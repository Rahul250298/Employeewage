using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    internal class Employee5
    {
         const int FULL_TIME = 1;
         const int PART_TIME = 2;
         const int EMP_RATE_PER_HR = 20;
         const int NUM_WORKING_DAYS = 20;
         int empHrs = 0;
         int totalWage = 0;
         int dailywage=0;
        public static void EmployeewageUc5()
        {
           for ( int day = 0;day<=NUM_WORKING_DAYS;day++)
            
            {
            
                Random random = new Random();
                int randomInput = random.Next(0, 3);
                switch (randomInput)
                {
                    case FULL_TIME:
                        //Console.WriteLine("Employee is present:fullTimeEmployee");
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        //Console.WriteLine("EmplOyee is present:PartTimeEmployee");
                        empHrs = 4;
                        break;
                    default:
                        //Console.WriteLine("Employee is absent");
                        empHrs = 0;
                        break;
                }
                 dailyWage = EMP_RATE_PER_HR* empHrs;
                 Console.WriteLine("daily Wage :" + dailyWage);
                 totalWage += dailyWage:
            }
            Console.WriteLine("Total employee wage for momth :" +  totalwage);
        }
    }
}
