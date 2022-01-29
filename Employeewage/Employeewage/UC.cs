using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    public class Employee
    {
        public static void Employeeattendance()
        {
            Random random = new Random();
            int fullTimeEmployee = 1;
            int randomInput = random.Next(0, 2);

            if(randomInput== fullTimeEmployee)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
