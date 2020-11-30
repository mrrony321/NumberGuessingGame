using System;

namespace numberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Console.WriteLine("what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi {0}, Welcome to the game...", name);
            //Console.WriteLine("")
            //declareing winnig variable;
            int winningNumber = 4;

            //taking inputs
            Console.WriteLine("Please enter a number between 1-10");
            Console.ForegroundColor = ConsoleColor.Green;
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            //Console.ResetColor();

            while(inputNumber != winningNumber)
            {
                Console.WriteLine("Please enter a number between 1-10");
                Console.ForegroundColor = ConsoleColor.Green;
                inputNumber = Convert.ToInt32(Console.ReadLine());
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Win!!!!Win!!!Win!!");
            Console.ResetColor();
            //if()



        }
    }
}
