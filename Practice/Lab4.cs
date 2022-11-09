using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Lab4
    {
        public static void TableOfPowers()
        {
            bool repeat = true;
            do
            {
                Begin();
                Repeat(repeat);
            }
            while (repeat == true);
        }
        static void Begin()
        {
            Console.WriteLine("Please enter a number:");
            float input = float.Parse(Console.ReadLine());
            SquaresAndCubes(input);
        }
        static void SquaresAndCubes(float input)
        {
            float n;
            for(n=1; n<=input; n++)
            {
                Console.Write("{0} squared {1} is :{2} \n", n, n, (n * n));
                Console.Write("{0} cubed {1} is :{2} \n", n, n, (n * n * n));
            }
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
    }
}
