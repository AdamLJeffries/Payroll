using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    internal class Print
    {
        public static void PrintRegularTime(double regularTime, double workedOverTime) 
        {
            if (regularTime + workedOverTime > regularTime) 
            {
                workedOverTime = Math.Round(workedOverTime, 2, MidpointRounding.AwayFromZero);
                Console.WriteLine($"You have worked {regularTime} Regular time hours and {workedOverTime} Overtime hours");
            }
            else
            {
                Console.WriteLine($"You have worked {regularTime} hours");
            }             
        }
    }
}
