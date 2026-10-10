//C# Calculator is a simple console application that performs basic arithmetic operations such as addition, subtraction, multiplication, and division. Below is a sample implementation of the calculator in C#:

Console.WriteLine("---Simple Calculator---");
float num1 , num2, result;
char symbol;

Console.WriteLine("Enter the first number: ");
num1 = float.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
num2 = float.Parse(Console.ReadLine());

Console.WriteLine("Enter the symbol for operation: ");
symbol = char.Parse(Console.ReadLine());

if(symbol == '+')
{
    result = num1 + num2;
    Console.WriteLine("The result is: " + result);
}
else if(symbol == '-')
{
    result = num1 - num2;
    Console.WriteLine("The result is: " + result);
}
else if(symbol == '*')
{
    result = num1 * num2;
    Console.WriteLine("The result is: " + result);
}
else if(symbol == '/')
{
    if(num2 != 0)
    {
        result = num1 / num2;
        Console.WriteLine("The result is: " + result);
    }
    else
    {
        Console.WriteLine("Division by zero is not allowed.");
    }
}
else
{
    Console.WriteLine("Invalid operation symbol.");
}
