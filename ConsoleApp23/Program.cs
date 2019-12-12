using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //i like this method for parsing answers to number-y questions
                bool okAnswer = false;
                int yearsOld = 0;
                while (!okAnswer)
                {
                    Console.WriteLine("How old are you?");
                    okAnswer = int.TryParse(Console.ReadLine(), out yearsOld);
                    if (!okAnswer) Console.WriteLine("I meant in years\n" +
                        "Enter a whole number, please.");
                }

                //throw errors at my custom exceptions (below)
                if (yearsOld == 0) throw new BabyException();
                if (yearsOld < 0) throw new TimeTravelerException();

                //continue if no errors in process
                int birthYear = DateTime.Now.Year - yearsOld;
                Console.WriteLine("You were born in {0}.", birthYear);

                Console.Read();
            }
            catch (BabyException)
            {
                Console.WriteLine("No way! If you are 0 years old then you must be a baby, \n" +
                    "Baby's should not be allowed on computers!!");
                Console.Read();

            }
            catch (TimeTravelerException)
            {
                Console.WriteLine("Born in the future huh?  The Time Police have been notified\n" +
                    "Good luck runnin' from them!");
                Console.Read();
            }
            catch (Exception)
            {
                //won't get hit because i wrapped the whoel thing in an "okAnswer bool thingy,
                //but i understand that this exception would get hit if the user entered an 
                //unparsable string (like "ten" or 12.2)
                Console.WriteLine("Idk what happened buddy but you're SOL.");
                Console.Read();
            }

        }

        public class BabyException : Exception
        {
            public BabyException() 
                : base() { }

            public BabyException(string message)
                : base(message) { }
        }

        public class TimeTravelerException : Exception
        {
            public TimeTravelerException()
                : base() { }
            public TimeTravelerException(string message)
                : base(message) { }
        }

    }
}
