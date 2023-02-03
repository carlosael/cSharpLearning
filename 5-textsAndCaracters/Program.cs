using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executing project 5 - texts and characters");

        char letter = 'a';
        Console.WriteLine(letter);

        letter = (char)65;
        Console.WriteLine(letter);

        letter = (char)(65 + 1);
        Console.WriteLine(letter);

        Console.WriteLine("Type 'Enter' to close.");

        Console.ReadLine();
    }
}