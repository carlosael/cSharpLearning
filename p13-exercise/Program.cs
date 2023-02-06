using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executing project 13 - for chaining");

        for (int x = 0; x < 100; x++)
        {
            if (x % 3 == 0)
            {
                Console.WriteLine(x);
            }
              
        }

        Console.WriteLine("Type 'Enter' to close.");

        Console.ReadLine();
    }
}