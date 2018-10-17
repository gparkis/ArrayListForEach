using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] starterString = {"I said ", "It was so ", "Many times I want to " };
            Console.WriteLine("Write a few words...");
            string userInput = Console.ReadLine();
            for (int i = 0; i<starterString.Length; i++)
            {
                starterString[i] += userInput;
            }
            for (int i=0; i<starterString.Length; i++)
            {
                Console.WriteLine(starterString[i] + "\n");
            }

            //infinite loop
            /*
            while (true)
            {
                Console.Write("You are gonna want to kill this. Hit CTRL+C");
            }
            */

            int count = 0;
            while (count < 10)
            {
                Console.WriteLine(count);
                count++;
            }

            // above code can easily become <= 

            List<string> uniques = new List<string>();
            uniques.Add("bananas");
            uniques.Add("bread");
            uniques.Add("milk");

            Console.WriteLine("Give me some text to search for");
            string userSearch = Console.ReadLine();

            foreach (string unique in uniques)
            {
                if (unique.Contains(userSearch))
                {
                    Console.WriteLine(uniques.IndexOf(userSearch));
                    break;
                }
                else
                {
                    Console.WriteLine("You entered text not found in list");
                }
            }



            List<string> duplicates = new List<string>();
            duplicates.Add("Sarah");
            duplicates.Add("Cash");
            duplicates.Add("Johnny");
            duplicates.Add("Sarah");
            List<string> duplicates2 = new List<string>();

            foreach (string name in duplicates)
            {
                if (!duplicates2.Contains(name))
                {
                    Console.WriteLine("The name " + name + " does not exits in list yet");
                    duplicates2.Add(name);
                }
                else
                {
                    Console.WriteLine("The name " + name + " is ALREADY in list");
                }
            }







            Console.Read();
        }
    }
}
