using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executing project 9 - calculate savings");

        double investment = 1000;

        // 0.5% yield/month

        Console.WriteLine(investment);

        for (int month = 1; month <= 12;month++) 
        { 
            investment *= 1.005;
            Console.WriteLine("On the month " + month + " you will have R$ " + investment);
        }

        Console.WriteLine("Type 'Enter' to close.");

        Console.ReadLine();
    }
}