namespace Payroll
{
    internal class Program
    {

        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            int num01;
            //hours worked    
            int num02;
            //hourly wage
            int num03;
            //time and a half payint overtime;     //amount paid with overtime hours int main()
            {

                Console.Write("How much do you make an hour?");
                num01 = Convert.ToInt32(Console.ReadLine());

                Console.Write("How many hours did you work this week?");
                num02 = Convert.ToInt32(Console.ReadLine());

                Console.Write("How many hours did you work this week over 40?");
                num03 = Convert.ToInt32(Console.ReadLine());

                int regularPay;  //amount made if worked 40hrs    
                int extraPay;    //amount made if worked anything over 40hrs    
                regularPay = (num01 * 40);
                extraPay = (num03 - 40) * num02;
                _ = num01 + (num01 / 2);

                if (num01 <= 40)
                {
                    Console.WriteLine("Your wage is {0}.", regularPay);
                }
                else
                {
                    Console.WriteLine("Your extra wage is {0}.", extraPay);

                }

            }
        }
    }
}