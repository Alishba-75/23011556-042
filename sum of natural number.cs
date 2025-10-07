using System;

public class sum_of_natural_numbers
{
    public void sum()
    {
        Console.Write("Enter a number n: ");
        int n = int.Parse(Console.ReadLine());
        int total = 0;

        for (int i = 1; i <= n; i++)
            total += i;

        Console.WriteLine($"Sum of numbers from 1 to {n} = {total}");
    }
}