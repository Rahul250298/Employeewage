using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    internal class Employee5
    {
        public static void EmployeewageUc6()
        { 
           const int FULL_TIME = 1;
           const int PART_TIME = 2;
           const int EMP_RATE_PER_HR = 20;
           const int MAX_WORKING_DAYS = 20;
            Random random = new Random();
            int dailyWage = 0;
            int empHrs = 0;
            int totalWage = 0;
            int workingHrs = 0;
           for ( int day = 1;day<=MAX_WORKING_DAYS;day++)
            
            {
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
    Console.WriteLine("daily Wage for day {0} is:{1} " ,day, dailyWage);
                totalWage += dailyWage;
                day++;
                //workingHrs = workingHrs + empHrs;
            }
Console.WriteLine();
Console.WriteLine("Total wage {0} Days is :{1}",MAX_WORKING_DAYS , totalWage );
            Console.ReadLine();
        }

    }
}