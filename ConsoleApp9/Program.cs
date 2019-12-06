using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);

        //List<string> strList = new List<string>();
        //strList.Add("Robbie");
        //strList.Add("Cunningham");

        //int[] numArray = new int[3];
        //numArray[0] = 1;
        //numArray[1] = 10;
        //numArray[2] = 100;

        //int[] numArray1 = new int[] {2, 20, 200};

        //int[] numArray2 = { 3, 30, 300 }

        List<string> strList = new List<string> { "A", "B", "C" };
        List<int> intList = new List<int> { 1, 2, 3 };
        string errorMessage = "List index out of range.";
        List<string> strList2 = new List<string> { "x", "y", "z" };

        Console.WriteLine("Choose an index (0, 1 or 2).");
            int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 0 || choice == 1 || choice == 2)
        {
            Console.WriteLine(strList[choice]);
        }
        else Console.WriteLine(errorMessage);

        Console.WriteLine("Choose an index (0, 1 or 2).");
            choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 0 || choice == 1 || choice == 2)
        {
            Console.WriteLine(intList[choice]);
        }
        else Console.WriteLine(errorMessage);

        Console.WriteLine("Choose an index (0, 1 or 2).");
            choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 0:
                Console.WriteLine(strList2[choice]);
                break;
            case 1:
                Console.WriteLine(" " + strList2[choice]);
                break;
            case 2:
                Console.WriteLine("  " + strList2[choice]);
                break;
            default:
                Console.WriteLine(errorMessage);
                break;
        }
        Console.Read();
    }
}

