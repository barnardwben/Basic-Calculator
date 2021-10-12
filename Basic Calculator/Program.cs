using System;

namespace Basic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator();
         
            Console.ReadLine();
        }

        static void Calculator()
        {
           Console.Write("Enter in a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Choose an operation you would like to perform");
            Console.WriteLine($"\ta - ADD");
            Console.WriteLine($"\ts - SUBTRACT");
            Console.WriteLine($"\tm - MULTIPLY");
            Console.WriteLine($"\td - DIVIDE");
            Console.WriteLine($"\tr - REMAINDER");
            Console.WriteLine($"\te - EXPONENTIATE");
            Console.Write($"Your operation: ");
            string operation = Console.ReadLine();

            Console.Write("Enter in another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());


           
            
            switch(operation)
            {
                case "a":
                    Console.WriteLine($"{num1 + num2}");
                    break;
                case "s":
                    Console.WriteLine($"{num1 - num2}");
                    break;
                case "m":
                    Console.WriteLine($"{num1 * num2}");
                    break;
                case "d":
                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"{num1 / num2}");
                    break;
                case "r":
                    Console.WriteLine($"{num1 % num2}");
                    break;
                case "e":
                    Console.WriteLine($"{Math.Pow(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }

            Console.WriteLine("Would you like to do another operation?");
            Console.WriteLine("\ty - yes");
            Console.WriteLine("\tany other key - no");
            Console.Write("Selection: ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "y":
                    Calculator();
                    break;
                default:
                    Environment.Exit(0);
                    break;

            }

        }
    }
}
