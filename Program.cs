using System.Linq;

namespace Payroll
{
    internal class Program
    {
        static void Main()
        {
           
            {
                //TODO: Figure out if you can legally round an employee's money down.

                bool stayOpen = true;
                
                do
                {
                    Console.WriteLine("What is your hourly rate?");
                    //TODO: Fix for case where user would enter "Twenty dollars an hour"
                    double hourlyRate = Convert.ToDouble(Console.ReadLine().Replace("$", ""));

                    Console.WriteLine("How many hours did you work?");
                    double time = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("When does overtime kick in?");
                    double overTimeHours = Convert.ToDouble(Console.ReadLine());

                    double workedOverTime = Calc.CalcWorkedOT(time, overTimeHours);
                    double regularTime = Calc.CalcRegTime(time, workedOverTime, overTimeHours);

                    double grossPay = (hourlyRate * regularTime);

                    double overtimePay = (hourlyRate * workedOverTime / 2) + hourlyRate * workedOverTime;
                    double OT = overtimePay + grossPay;

                    Print.PrintRegularTime(regularTime, workedOverTime);

                    switch (workedOverTime)
                    {
                        case >= 0:
                            OT = Math.Round(OT, 2, MidpointRounding.AwayFromZero);
                            Console.WriteLine($"Your gross pay and overtime will be in the amount of ${OT}");                       
                            break;
                        default:
                            grossPay = Math.Round(grossPay, 2, MidpointRounding.AwayFromZero);
                            Console.WriteLine($"Your gross pay is + {grossPay}");
                            break;
                    }

                    Console.WriteLine("\r\nWould you like to calculate another payroll?");
                    string answer = Console.ReadLine().ToLower();
                    List<string> exitCmds = new List<string>() { "exit", "terminate", "stop", "quit", "end", "no"};

                    if (exitCmds.Any(s => answer.Contains(s)))
                    {
                        stayOpen = false;
                    }
                    else
                    {
                        Console.WriteLine("\r\n=========================================");
                        Console.WriteLine("========Dolla Dolla Bills, Yall!=========");
                        Console.WriteLine("=========================================\r\n");
                    }
                } while (stayOpen);

                Console.WriteLine("\r\n====================================================");
                Console.WriteLine("=========Don't spend it all in one place!===========");
                Console.WriteLine("====================================================");
            }
        }
    }
}