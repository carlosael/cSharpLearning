using System;
class Program
{
    static void Main(string[] args)
    {
        double salary;
        salary = 3000.15;
        Console.WriteLine(salary);


        int intergerSalary;
        intergerSalary = (int)salary;
        Console.WriteLine(intergerSalary);


        // Long is a variable that holds 64 bits
        long x = 200000000000;
        Console.WriteLine(x);


        short y = 15000;
        Console.WriteLine(y);

        float height = 1.96f;
        Console.WriteLine(height);

        Console.WriteLine("Type 'Enter' to close.");
        Console.ReadLine();
    }
}
