using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a number.");
            string sNumber1 = Console.ReadLine();
            double dNumber1 = Convert.ToDouble(sNumber1);
            Console.WriteLine("Your number times 50 is " + dNumber1*50);


            Console.WriteLine("Okay, gimme another one.");
            string sNumber2 = Console.ReadLine();
            long iNumber1 = Convert.ToInt64(sNumber2);
            Console.WriteLine("Your number plus 25 is " + (iNumber1 + 25));
            

            Console.WriteLine("Let's go again.");
            string sNumber3 = Console.ReadLine();
            double dNumber2 = Convert.ToDouble(sNumber3);
            Console.WriteLine("Divided by 12.5: " + dNumber2/12.5);
            

            Console.WriteLine("Gimme one and I'll tell you whether or not it's bigger than 50!");
            string sNumber4 = Console.ReadLine();
            long iNumber2 = Convert.ToInt64(sNumber4);
            bool isBiggerThan50 = (iNumber2 > 50);
            Console.WriteLine("Saying that your number is bigger than 50 is " + isBiggerThan50);
            

            Console.WriteLine("Okay wait til you see this one!!");
            string sNumber5 = Console.ReadLine();
            int iNumber3 = Convert.ToInt32(sNumber5);
            int iNumber3mod7 = iNumber3 % 7;
            Console.WriteLine(sNumber5 + " is " + iNumber3mod7 + " mod 7!");
            Console.Read();

        }
    }
}
