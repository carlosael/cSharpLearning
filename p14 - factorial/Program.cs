using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executing project 13 - for chaining");
        int result = 1;
        for (int x = 0; x <= 10; x++)
        {
            if (x == 0 || x == 1)
            {
                Console.WriteLine("The factorial of " + x + " is 1");
            } else
            {
                result = x * result;
                Console.WriteLine("The factorial of " + x + " is " + result);
            }

        }

        Console.WriteLine("Type 'Enter' to close.");

        Console.ReadLine();
    }
}
