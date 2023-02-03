using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executing project 7 - conditionals");

        int johnAge = 16;
        bool group = true;

        if (johnAge >= 18 || group)
        {
            Console.WriteLine("You may enter!");
        }
        else
        {
            Console.WriteLine("You cannot enter");
        }

        Console.WriteLine("Type 'Enter' to close.");

        Console.ReadLine();
    }
}