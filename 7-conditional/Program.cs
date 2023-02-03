using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executing project 7 - conditionals");

        int johnAge = 16;
        int guests = 2;

        if (johnAge >= 18)
        {
            Console.WriteLine("You may enter!");
        }
        else
        {
            if (guests > 0)
            {
                Console.WriteLine("You're with someone. You may enter!");
            }
            else
            {
                Console.WriteLine("You cannot enter");
            }
        }

        Console.WriteLine("Type 'Enter' to close.");

        Console.ReadLine();
    }
}