using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram195Day3
{
   public class EmployeeProgram1
    {
        public static void EmployeA()
        {
            //Constants
            int IS_FULL_TIME = 1;
            Random random = new Random();
            //Computation
            int empCheck = random.Next();   
            if(empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employe is Praent");
            }
            else
            {
                Console.WriteLine("Employe is Absent");
            }
        }
    }
}
