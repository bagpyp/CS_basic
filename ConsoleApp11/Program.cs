using System;

class Program
{
    static void Main(string[] args)
    {
        //try
        //{
        //    Console.WriteLine("Pick a number.");
        //    int numberOne = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Pick another.");
        //    int numberTwo = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Dividing the two...");
        //    int numberThree = numberOne / numberTwo;

        //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
        //    Console.ReadLine();
        //}
        //catch (FormatException ex)
        //{
        //    Console.WriteLine("Please type a whole number");
        //}
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("No divvie by zero bb!");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //finally
        //{
        //    Console.ReadLine();
        //}
        try
        {
            int[] nums = { 12, 14, 92, 22, 321, 5354, 65, 43, 2324, 34 };

            Console.WriteLine("Check out this list of numbers!");
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Gimme a number I can divide 'em all by!");

            int divisor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Okay check this out.");
            foreach (int num in nums)
            {
                int result = num / divisor;
                Console.WriteLine(num + " divided by " + divisor + " equals " + result);
            }

            //dividing by 0 gives result = to inifinity
            //dividing by "Robbie" gives format exception
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("No dividie by zero bb!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }







    }
}

