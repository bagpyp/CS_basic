using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {

            //string textBoxAnswer = "True";
            //bool hasValidDriversLicense = Convert.ToBoolean(textBoxAnswer);
            //if (hasValidDriversLicense)
            //{
            //    //some code
            //}

            //Console.WriteLine("How old are you");
            //string age = Console.ReadLine(); //31
            //float yearsInCentury = 100f;
            //float ageInCenturies = (float)age / yearsInCentury
            //Console.WriteLine("You are " + ageInCenturies + " centuries old.");
            //    //You are .31 centuries old.

            //bool isStudying = false;
            //byte hoursWorked = 42;
            //sbyte currentTemperature = -23;
            //char questionMark = '\u2103';
            //decimal moneyInBank = 100.52m;
            //double heightInCentimeters = 211.2341432;
            //float secondsLeft = 2.62f;
            //short temperatureOnMars = -341;

            Console.WriteLine("The Tech Academy, press enter for daily report");
            Console.Read();
            Console.WriteLine("Student Daily Report");
            Console.Read();
            Console.WriteLine("What Course Are you on?");
                string courseName = Console.ReadLine();
            Console.WriteLine("What Page number are you on?");
                uint pageNumber = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Do you need any help with anything? please answer 'true' or 'false'");
                bool needsHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specific.");
                string positiveExperiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
                string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
                byte hoursStudied = Convert.ToByte(Console.ReadLine());


            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();



        }
    }
}
