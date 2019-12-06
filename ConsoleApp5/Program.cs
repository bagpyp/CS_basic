using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            //int packageHeight = 25;
            //int packageWidth = 10;
            //bool tooBig = (packageHeight > 24 || packageWidth > 25);
            //Console.WriteLine(tooBig);

            //string firstName = "Robbie";
            //string lastName = "Cunningham";
            //string socialSecurityNumber = "111 - 11 - 1111";
            //bool isAuthorized = (firstName == "Robbie" && lastName == "Cunningham" && socialSecurityNumber == "111 - 11 - 1111");
            //Console.WriteLine(isAuthorized);

            //int bankAccountBalance = 500;
            //bool isInARockBand = false;
            //string name = "Robbie";
            //bool isReallyCool = (bankAccountBalance > 100000 || isInARockBand || name == "Robbie");

            // result = (true && (true || false));


            //Entrance
            Console.WriteLine("Welcome to the Drivers' Insurance Eligibility Machine.\n" +
                "Press Enter to Continue");
            Console.ReadLine();

            //Control
            Console.WriteLine("Firtly, what is your age?");
                            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for that information.  This next question is a little more personal...\n" +
                "Have you ever had a DUI? (please answer true or false)");
                bool hadDUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Thank you for your honesty... How many speeding tickets have you had?");
                int numTicks = Convert.ToInt32(Console.ReadLine());

            // View
            Console.WriteLine("Qualified?");

            //Branch
            Console.WriteLine(age > 15 && numTicks < 3 && hadDUI == false);

            //Exit
            Console.ReadLine();


        }
    }
}
