using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> favoriteThings = new List<string>();

            string answer;

            Console.WriteLine("What is one of your most favorite things? >>");
            answer = Console.ReadLine();
            do
            {

                favoriteThings.Add(answer);

                Console.WriteLine("Do you have another favorite thing to add? >>");
                answer = Console.ReadLine();
            } while (answer.ToLower()[0] != 'y');

            Random rand = new Random();
            int randomThingIndex = rand.Next(0, favoriteThings.Count);

            string randomThing = favoriteThings[randomThingIndex];
            Console.WriteLine($"Your random favorite thing is:\n{randomThing}");
        }
    }
}
