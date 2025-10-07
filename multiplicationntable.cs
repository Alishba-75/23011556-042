using System;

public class multiplication_table
{
    public void multiply()
    {
        Console.Write("Enter a number for multiplication table: ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{num} * {i} = {num * i}");
    }
}