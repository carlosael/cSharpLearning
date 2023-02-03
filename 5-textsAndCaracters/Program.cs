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

        string firstPhrase = "Alura - Technology courses ";
        Console.WriteLine(firstPhrase + 2022);

        string emptyString = "";
        Console.WriteLine(emptyString);

        string courses = @"Avaible courses:
- Go 
- C# 
- Python";
        Console.WriteLine(courses);

        Console.WriteLine("Type 'Enter' to close.");

        Console.ReadLine();
    }
}