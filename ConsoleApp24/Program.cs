using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a const variable
            const string whatItsAllAbout = "Things";
            //2. Create a variable using the keyword "var".
            var message = "Welcome to 'It's All About " + whatItsAllAbout + "!'";
            Console.WriteLine(message);

            Thing thing1 = new Thing("a car", 2000);
            Thing thing2 = new Thing("speed");

            Console.WriteLine(thing1.Name + " weighs " + thing1.Weight.ToString() + "pounds\n" +
                thing2.Name + " weights " + thing2.Weight.ToString() + "pounds\n" +
               "Bye!");

            Console.Read();
        }
    }
    public class Thing
    {
        //3. Chain two constructors together.
        public Thing(string name) : this(name, 0) { }
        public Thing(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; set; }
        public int Weight { get; set; }

    }
}
