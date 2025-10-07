using System;

public class reverse_number
{
    public void reversible()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int rev = 0;

        while (num > 0)
        {
            int digit = num % 10;
            rev = rev * 10 + digit;
            num /= 10;
        }

        Console.WriteLine($"Reversed number = {rev}");
    }
}