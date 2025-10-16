using System;
class Program
{
    static void Main()
    {
            double num1 = Read("Enter first number:");
            double num2 = Read("Enter second number:");
            Console.WriteLine("Choose an operation: +  -  *  /");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();
            switch (operation)
            {
                case '+':
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case '/':
                    if (num2 == 0)
                        Console.WriteLine("Cannot divide by zero.");
                    else
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("Unknown operation.");
                    break;
            }
            Console.WriteLine("Do you want to continue? (y/n)");
            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (choice == 'n' || choice == 'N'|| choice != 'y'|| choice != 'Y')
            {
                Console.WriteLine("Goodbye!");
                return;
            }
    }
    static double Read(string prompt)
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine();
        double number;

        while (!double.TryParse(input, out number))
        {
            Console.WriteLine("Incorrect input. Try again:");
            input = Console.ReadLine();
        }

        return number;
    }
}
