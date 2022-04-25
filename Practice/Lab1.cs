using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Lab1
    {
        public static void AreaAndPerimeter()
        {
            bool repeat = true;
            do
            {
                GreetingInput();
                Console.WriteLine("Sweet! Wanna redo the simulation?");
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
        static void GreetingInput()
        {
            Console.WriteLine("Hello! Are you ready for some math?");
            Console.WriteLine("Enter Length");
            float input1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Width");
            float input2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Your area is:");
            Console.WriteLine(Area(input1, input2));

            Console.WriteLine("Your parameter is:");
            Console.WriteLine(Perimeter(input1, input2));
        }
        static float Area(float num1, float num2)
        {
            float total = num1 * num2;
            return total;
        }
        static float Perimeter(float num1, float num2)
        {
            float total = (num1 * 2) + (num2 * 2);
            return total;
        }
    }
}
