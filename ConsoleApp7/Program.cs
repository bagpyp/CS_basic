using System;


namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = (number == 12);
            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.\n" +
                            "Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 20 Try again.\n" +
                            "Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55 Try again.\n" +
                            "Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 72:
                        Console.WriteLine("You guessed 72 Try again.\n" +
                            "Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed 12. You are correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.\n" +
                            "Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuessed);

            


            Console.Read();
        }
    }
}
