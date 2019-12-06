using System;


namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Packages Express\n" +
                "Press Enter to Continue and follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("How much does your package weigh?");
            float weight = Convert.ToSingle(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped by Package Express.  Goodbye.");
                return;
            }
            else
            {
                Console.WriteLine("Please Enter Package Height");
                float h = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Width?");
                float w = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Length?");
                float l = Convert.ToSingle(Console.ReadLine());

                if (l + w + h > 50)
                {
                    Console.WriteLine("Package is too large to be shipped by Package Express.  Goodbye.");
                    return;
                }
                else
                {
                    float quote = (l + h + w) * weight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is:\n" +
                        "$" + Math.Round(quote, 2) + "\n" +
                        "Thank you.");
                }
            }
            Console.ReadLine();

        }
    }
}
