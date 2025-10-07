using System;

public class max_min
{
    public void min_max()
    {
        int[] arr = new int[10];
        Console.WriteLine("Enter 10 numbers:");

        for (int i = 0; i < 10; i++)
            arr[i] = int.Parse(Console.ReadLine());

        int max = arr[0];
        int min = arr[0];

        for (int i = 1; i < 10; i++)
        {
            if (arr[i] > max)
                max = arr[i];
            if (arr[i] < min)
                min = arr[i];
        }

        Console.WriteLine($"Maximum number = {max}");
        Console.WriteLine($"Minimum number = {min}");

    }
}