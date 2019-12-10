using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing Test Score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //string[] names = { "Robbie", "Heather", "Savannah", "Louie" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    if (names[j] == "Robbie")
            //    {
            //        Console.WriteLine(names[j]);
            //    }
            //}
            //Console.ReadLine();

            //List<int> testScores0 = new List<int>();
            //testScores0.Add(98);
            //testScores0.Add(99);
            //testScores0.Add(81);
            //testScores0.Add(72);
            //testScores0.Add(70);

            //foreach (int score in testScores0)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing Test Score: " + score);
            //    }
            //}
            //Console.ReadLine();


            //List<string> names0 = new List<string>() { "Robbie", "Louis", "Waylan", "Lionel" };

            //foreach (string name in names0)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            //List<int> testScores1 = new List<int>() { 98, 99, 12, 74, 23, 99 };
            //List<int> passingScores = new List<int>();

            //foreach (int score in testScores1)
            //{
            //    if (score > 85)
            //    {
            //        passingScores.Add(score);
            //    }
            //}

            //Console.WriteLine(passingScores.Count);
            //Console.ReadLine();










            //1.
            string[] contactCard = { "Name: ", "Title: ", "Company: " };
            string[] questions = { "What is your name?", "What is your title?", "What company do you work for?" };

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                contactCard[i] += Console.ReadLine();
            }
            foreach (string data in contactCard)
            {
                Console.WriteLine(data);
                Console.ReadLine();
            }


            //2. and 3.
            //finite loop, for infinite loop replace "k < 100" below with "k > 0"
            int k = 1;
            while (k < 100)
            {
                k += 1;
                Console.WriteLine(k);
            }
            Console.ReadLine();

            //4. and 5. unecessary

            //6. 7. and 8.
            string errorMessage = "Sorry, that's not in my list :/";
            string successMessage = "You got it!  That letter is at index: ";

            string[] miniAlphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m" };
            Console.WriteLine("Pick a letter \"less than\" n and I'll let you know where it is in my list!");

            int index = 0;
            string searchTerm = Console.ReadLine();

            for (int l = 0; l < miniAlphabet.Length; l++)
            {
                if (miniAlphabet[l] == searchTerm)
                {
                    index += l;
                }
                else
                {
                    index += 0;
                }
            }
            if (index == 0)
            {
                Console.WriteLine(errorMessage);
            }
            else
            {
                Console.WriteLine(successMessage + index);
            }
            _ = Console.ReadLine();

            //9. and 10.
            string[] miniAlphabet2 = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "m" };
            Console.WriteLine("Pick a letter \"less than\" n and I'll let you know where it is in my list!, just wait til you see what happens with m!");
            string searchTerm2 = Console.ReadLine();

            //initialize list to house indeces where match occurs
            List<int> indeces = new List<int>();

            //iterate through list to test if match occurs, adding matching index to previous list
            for (int j = 0; j < miniAlphabet2.Length; j++)
            {
                if (miniAlphabet2[j] == searchTerm2)
                {
                    indeces.Add(j);
                }
            
            //if no matches occur, apologize
            }
            if (indeces.Count == 0)
            {
                Console.WriteLine(errorMessage);
            }

            //if matcheds do occur, give a success message that lists all locations of matched search term
            else
            {
                Console.WriteLine(successMessage + indeces[0]);
                for (int m = 1; m < indeces.Count; m++)
                {
                    Console.WriteLine("and " + indeces[m]);
                }
            }
            Console.ReadLine();

            //11.
            List<string> iterableList = new List<string>() { "a", "b", "c", "b", "c" };
            Console.WriteLine("press enter to see some info about my next list");
            Console.ReadLine();

            List<string> tempList = new List<string>();

            int count = 0;
            foreach (string item in iterableList) 
            {
                count++;
                if (tempList.Contains(item)) 
                {
                    Console.WriteLine("item {0}: " + item + ", which has already appeared in this list.", count);
                }
                else 
                {
                    Console.WriteLine("item {0}: " + item + ", which has not already appeared in this list.", count);
                }
                tempList.Add(item);
            }

                        
            _ = Console.ReadLine();

        }
    }
}
