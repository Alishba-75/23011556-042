using System;

public class factorial_calculator
{
    public void calculate ()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        long fact = 1;
        int i = 1;

        while (i <= n)
        {
            fact *= i;
            i++;
        }

        Console.WriteLine($"Factorial of {n} = {fact}");
    }
}