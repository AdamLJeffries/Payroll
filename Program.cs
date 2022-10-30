namespace Payroll
{
    internal class Program
    {
        static void Main()
        {
           
            {
                bool stayOpen = true;
                
                do
                {
                    Console.WriteLine("What is your hourly rate?");

                    //TODO: Fix for case where user would enter "Twenty dollars an hour"
                    double hourlyRate = Convert.ToDouble(Console.ReadLine().Replace("$", ""));
                    Console.WriteLine("How many Regular Time hours did you work?");
                    double regularTime = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("How many Overtime hours did you work his week?");
                    double overTime = Convert.ToDouble(Console.ReadLine());
                    double grossPay = (hourlyRate * regularTime);

                    double overtimePay = (hourlyRate * overTime / 2) + hourlyRate * overTime;
                    double OT = overtimePay + grossPay;

                    switch (overTime)
                    {
                        case >= 0:
                            Console.WriteLine($"Your gross pay and overtime will be in the amount of ${OT}");
                            break;
                        default:
                            Console.WriteLine($"Your gross pay is + {grossPay}");
                            break;
                    }

                    Console.WriteLine("\r\nWould you like to calculate another payroll?");
                    string answer = Console.ReadLine().ToLower();

                    if (answer != "yes") // TODO: Better user answer acceptance
                    {
                        stayOpen = false;
                    }
                    else
                    {
                        Console.WriteLine("\r\n========================================");
                        Console.WriteLine("========Dolla Dolla Bills, Yall!=========");
                        Console.WriteLine("========================================\r\n");
                    }
                } while (stayOpen);

                Console.WriteLine("\r\n====================================================");
                Console.WriteLine("=========Don't spend it all in one place!===========");
                Console.WriteLine("====================================================");
            }
        }
    }
}