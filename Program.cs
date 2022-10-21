namespace Payroll
{
    internal class Program
    {
        static void Main()
        {
           
            {

                Console.Write("What is your hourly rate?");
                int v1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many Regular Time hours did you work?");
                int v2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("How many Overtime hours did you work this week?");
                int v3 = Convert.ToInt32(Console.ReadLine());
                int grossPay = (v1 * v2);
                 
                int overtimePay = (v1 * v3 / 2) + v1 * v3;
                int OT = overtimePay + grossPay;

                switch (v3)
                {
                    case >= 0:
                        Console.WriteLine($"Your gross pay and overtime will be in the amount of ${OT}");

                        break;
                    default:
                        Console.WriteLine($"Your gross pay is + {grossPay} ");
                        break;
                }

            }
        }
    }
}