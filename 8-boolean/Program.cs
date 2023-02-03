using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executing project 7 - conditionals");

        int johnAge = 16;
        int guests = 2;
        bool group = guests > 1;

        string aditionalText;

        if (group == true)
        {
            aditionalText = "John is with someone";
        }
        else
        {
            aditionalText = "John is alone";
        }

        if (johnAge >= 18 || group)
        {
            Console.WriteLine(aditionalText);
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