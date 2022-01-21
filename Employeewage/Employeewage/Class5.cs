using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    internal class Employee4
    {
        public static void EmployeewageUc4()
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            const int MAX_WORKING_DAYS = 20;
            const int MAX_WORKING_HRS = 60;
            Random random = new Random();
            int dailyWage = 0;
            int empHrs = 0;
            int totalWage = 0;
            int day =1,workingHrs =0;
           
            while (day<= MAX_WORKING_DAYS && workingHrs<=MAX_WORKING_HRS)
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
                dailyWage = EMP_RATE_PER_HR * empHrs;
                Console.WriteLine("daily Wage for day {0} is:{1} and working hrs is :{2}" ,day, dailyWage,workingHrs);
                totalWage += dailyWage;
                day++;
                workingHrs = workingHrs + empHrs;
            }
            Console.WriteLine();
            Console.WriteLine("Total wage {0} Days is :{1}and Hrs is:{ 2}", day,totalWage,workingHrs);
            Console.ReadLine();
        }

    }
}






