using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executing project 13 - for chaining");

        for (int lineCounter = 0; lineCounter <= 9; lineCounter++)
        {
            for (int columnCounter = 0;columnCounter <= 9; columnCounter++)
            {
                Console.Write("*");
                if (columnCounter >= lineCounter)
                    break;
            }
           Console.WriteLine();
        }

        for (int lineCounter = 0; lineCounter <= 9; lineCounter++)
        {
            for (int columnCounter = 0; columnCounter <= lineCounter; columnCounter++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Type 'Enter' to close.");

        Console.ReadLine();
    }
}