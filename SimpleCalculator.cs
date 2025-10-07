using System;

public class simple_calculator
{
    public void calculation()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter operation (+, -, *, /): ");
        char op = char.Parse(Console.ReadLine());

        switch (op)
        {
            case '+':
                Console.WriteLine($"Result = {a + b}");
                break;
            case '-':
                Console.WriteLine($"Result = {a - b}");
                break;
            case '*':
                Console.WriteLine($"Result = {a * b}");
                break;
            case '/':
                if (b != 0)
                    Console.WriteLine($"Result = {a / b}");
                else
                    Console.WriteLine("Cannot divide by zero!");
                break;
            default:
                Console.WriteLine("Invalid operator!");
                break;
        }
    }
}