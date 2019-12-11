using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            //demonstrate text logging and streamwriter usage.
            Console.WriteLine("Gimme a number");
            string number = Console.ReadLine();
            File.WriteAllText(@"C:/Users/rober/CS/basic/ConsoleApp16/log.txt", number);
            using (StreamWriter file = new StreamWriter(@"C:/Users/rober/CS/basic/ConsoleApp16/log.txt", append: true))
            {
                file.WriteLine(" is the number you entered");
            }
            string message = File.ReadAllText(@"C:/Users/rober/CS/basic/ConsoleApp16/log.txt");
            Console.WriteLine(message);
            Console.Read();
        }
    }
}
