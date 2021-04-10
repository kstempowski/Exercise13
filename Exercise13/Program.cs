using System;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 13");
            bool repeat = true;
            while (repeat)
            {
                //Prompt the user for input
                Console.WriteLine("Please enter a number greater than 0");
                string input = Console.ReadLine();
                int number = int.Parse(input);

                for (int i = 0; number >= i; number--)
                {
                    Console.WriteLine(number);
                }
                //prompt the user for additional input
                Console.WriteLine("Enter another number? y/n");
                string answer = Console.ReadLine();

                if (answer == "y")
                {
                    //An answer if "y" will repeat the program
                    repeat = true;
                }
                else
                {
                    //Any answer other than "y" will terminate the program
                    Console.WriteLine("Goodbye!");
                    repeat = false;
                }
            }
        }
    }
}
