namespace Payroll
{
    internal class Program
    {
        public static void Main(string[] Payroll)
        {
           
            {

                Console.Write("What is your hourly rate?");
                int v1 = Convert.ToInt32(Console.ReadLine());
                int hours = v1;
                Console.WriteLine("How many hours did you work?");
                int v2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("How many hours did you work over 40 this week?");
                int v3 = Convert.ToInt32(Console.ReadLine());
                int grossPay = (v1 * v2);
                 
                int v5 = v3 * v2 / 2 + v3 * v2;
                int overtimepay = v5 + grossPay;
                bool v = hours <= 40;
                if (v)
                {
                    Console.WriteLine("Your wage is " + grossPay);
                }
                else
                {

                    Console.WriteLine(value: "Your extra wage is " + overtimepay);

                }

            }
        }
    }
}