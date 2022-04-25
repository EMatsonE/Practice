using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Lab2
    {
        public static void EvenOdd100s()
        {
            string name = Greeting();
            bool repeat = true;
            do
            {
                Begin(name);
                Console.WriteLine("Would you like to go again?");
                string redo = Console.ReadLine();
                if (redo == "yes")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                    Environment.Exit(0);
                }
            }
            while (repeat == true);
        }
        static string Greeting()
        {
            Console.WriteLine("Hello! What is your name?");
            string name = Console.ReadLine();
            return name;
        }
        static void Begin(string name)
        {
            Console.WriteLine($"Please enter a number {name}");
            float input = float.Parse(Console.ReadLine());

            GoThrough(input, name);
        }
        static void GoThrough(float input, string name)
        {
            if (input < 1 || input > 100)
            {
                Console.WriteLine("Please put valid input");
                Begin(name);
            }
            else
            {
                EvenOdds(input);
                Ranges(input);
            }
        }
        static void EvenOdds(float input)
        {
            if (input % 2 == 0)
            {
                Console.WriteLine($"{input} is even");
            }
            else
            {
                Console.WriteLine($"{input} is odd");
            }
        }
        static void Ranges(float input)
        {
            if (input < 25)
            {
                Console.Write(" and under 25");
            }
            if (input < 60 && input > 26)
            {
                Console.WriteLine(" and it is between 25 and 60");
            }
            if (input > 60)
            {
                Console.WriteLine(" and it is bigger than 60");
            }
        }
    }
}
