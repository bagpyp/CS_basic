using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Robbie";
            string quote = "\"Life is too short to eat the crust.\"";

            string p = name + " said " + quote + "\n\t-Dumb People\\" + name + ".";
            Console.WriteLine(p);
            Console.ReadLine();

            bool check = name.Contains("o") && name.EndsWith("e") && name.Length == 6 && name.ToUpper().Contains("O") && name.ToLower().StartsWith("r");

            Console.WriteLine(check);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Robbie. ");
            sb.Append("I'm a computer programmer. ");
            sb.Append("You can pay me lots of money to write code. ");
            sb.Append("Don't Panic!");

            Console.WriteLine(sb);
            Console.Read();
            

        }
    }
}
