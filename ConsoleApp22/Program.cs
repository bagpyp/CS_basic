using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current day and time is: " + DateTime.Now + "\n" +
                "Please, enter a number.");

            int input = Convert.ToInt32(Console.ReadLine());

            TimeSpan hours = new TimeSpan(input, 0, 0);

            Console.WriteLine("In {0} hours it will be {1}", input, DateTime.Now + hours);

            Console.Read();
        }
    }
}
