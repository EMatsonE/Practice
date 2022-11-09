using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Lab2
    {
        public static void EvenOdd100s()
        {
            string name = Greeting();
            bool repeat = true;
            do
            {
                Begin(name);
                Repeat(repeat);
            }
            while (repeat == true);
        }
        static void Repeat(bool repeat)
        {
            Console.WriteLine("Would you like to go again?");
            string redo = Console.ReadLine();
            if (redo.ToLower() == "yes" || redo.ToLower() == "y")
            {
                repeat = true;
            }
            else if (redo.ToLower() == "no" || redo.ToLower() == "n")
            {
                repeat = false;
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid answer");
                Repeat(repeat);
                return;
            }
        }
        static string Greeting()
        {
            Console.WriteLine("Hello! What is your name?");
            string name = Console.ReadLine();
            
            if (name == "" || name == null)
            {
                Console.WriteLine("I'm sorry your answer is blank");
                Greeting();
            }
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
            if(input.ToString() == "")
            {
                Console.WriteLine("That was blank please try again");
                Begin(name);
            }
            else if (input < 1 || input > 100)
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
                Console.WriteLine("It is under 25");
            }
            if (input < 60 && input > 26)
            {
                Console.WriteLine("It is between 25 and 60");
            }
            if (input > 60)
            {
                Console.WriteLine("It is bigger than 60");
            }
        }
    }
}
