using System;

public class count_even_odd
{
    public void count()
    {
        int[] arr = new int[10];
        int even = 0, odd = 0;

        Console.WriteLine("Enter 10 numbers:");
        for (int i = 0; i < 10; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            if (arr[i] % 2 == 0)
                even++;
            else
                odd++;
        }

        Console.WriteLine($"Even numbers = {even}");
        Console.WriteLine($"Odd numbers = {odd}");
    }
}
