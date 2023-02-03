using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executing project 9 - calculate savings");

        double investment = 1000;

        // 0.5% yield/month

        Console.WriteLine(investment);

        int month = 1;

        while (month <= 12)
        {
            investment = investment + investment * 0.005;
            Console.WriteLine("On the month" + month + "you will have R$ " + investment);
            month++;
        }

        Console.WriteLine("Type 'Enter' to close.");

        Console.ReadLine();
    }
}
