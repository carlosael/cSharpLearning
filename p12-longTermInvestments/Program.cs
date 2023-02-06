using Microsoft.VisualBasic;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executing project 12 - long term investment");

        double investmentRate = 1.005;
        double investmentValue = 1000;


        for (int years = 1; years <= 5; years++)
        {
            for (int month = 1; month <= 12;month++)
            {
                investmentValue *= investmentRate;
            }
            investmentRate += 0.001;
        }

        Console.WriteLine("After 5 years you will have R$ " + investmentValue);

        Console.WriteLine("Type 'Enter' to close.");

        Console.ReadLine();
    }
}