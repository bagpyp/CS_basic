using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        
        static void Main()
        {
            try
            {
                Console.WriteLine("What Day of the Week is it?");
                Day day;
                bool canParse;
                canParse = Enum.TryParse(Console.ReadLine(), out day);
                if (canParse) Console.WriteLine(day + ", huh");
                else throw new Exception();

            }
            catch (Exception)
            {
                Console.WriteLine("Don't be cheeky!");
            }
            Console.ReadLine();
        }
        public enum Day
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
