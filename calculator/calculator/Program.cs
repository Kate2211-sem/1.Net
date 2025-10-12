// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter first number");
string input=Console.ReadLine();
int result;
    while (!int.TryParse(input, out result))
    {
        Console.WriteLine("No correct");
        input = Console.ReadLine();
    }

    Console.WriteLine("Enter second number");
string input2 = Console.ReadLine();
int result2;
    while (!int.TryParse(input2, out result2))
    {
        Console.WriteLine("No correct");
        input = Console.ReadLine();
    }
    Console.WriteLine("choose an operation");
Console.WriteLine("+");
Console.WriteLine("-");
Console.WriteLine("*");
Console.WriteLine("/");
char operation=Console.ReadKey().KeyChar;
Console.WriteLine();
switch(operation)
    {
    case '+':
        Console.WriteLine($"{result} + {result2} = {result + result2}");
        break;
    case '-':
        Console.WriteLine($"{result} - {result2} = {result - result2}");
        break;
    case '*':
        Console.WriteLine($"{result} * {result2} = {result * result2}");
        break;
    case '/':
        if (result2 == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        else
        {
            Console.WriteLine($"{result} / {result2} = {(double)result / result2}");
        }
        break;
        default:
            Console.WriteLine("Unknown operation.");
        break;
    }
Console.WriteLine("Do you want to continue(y/n)");
char choose =Console.ReadKey().KeyChar;
Console.WriteLine();
if (choose == 'n' || choose == 'N'|| choose !='y')
{

    Console.WriteLine("Goodbye!");
    return;

}



