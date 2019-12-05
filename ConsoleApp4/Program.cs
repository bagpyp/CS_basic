using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            //Entrance
            Console.WriteLine("Anonymous Income Comparison Program");


            //Control
            Console.WriteLine("Person 1\n" +
                "Hourly Rate?");
                float rate1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
                float weeklyHours1 = Convert.ToSingle(Console.ReadLine());

                    //Calculate Person 1's weekly salary
                    float weeklySalary1 = rate1 * weeklyHours1;

            Console.WriteLine("Person 2\n" +
                "Hourly Rate?");
                float rate2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
                float weeklyHours2 = Convert.ToSingle(Console.ReadLine());

                    //Calculate Person 2's weekly salary
                    float weeklySalary2 = rate2 * weeklyHours2;

            //Branch (kinda)
            bool p1makesMoreThanP2 = weeklySalary1 > weeklySalary2;

            //View
            Console.WriteLine("Weekly salary for Person 1:\n" +
                weeklySalary1.ToString());

            Console.WriteLine("Weekly salary for Person 2:\n" +
                weeklySalary2.ToString());

            Console.WriteLine("Does Person 1 make more money than Person 2?\n" +
                p1makesMoreThanP2.ToString());

            //Exit
            Console.ReadLine();



        }
    }
}