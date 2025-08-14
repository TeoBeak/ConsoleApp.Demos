// See https://aka.ms/new-console-template for more information
// Welcome Message
using System;

Console.WriteLine("********** - Welcome to the sample calculator! - **********");

// Variable Declaration

int choice = 0;
int num1, num2 = 0;

// Show calculator options / Show menu

while (choice != -1)
{
    try
    {
        PrintMenu();
        

        choice = Convert.ToInt32(Console.ReadLine());

        if (choice == -1)
        {
            break;
        }

        // Prompt for user input
        Console.Write("Please enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());



        // Decide which operation is needed based on selected option

        int answer = 0;
        switch (choice)
        {
            case 1:
                answer = AddNumbers(num1, num2);
                break;
            case 2:
                answer = SubtractNumbers(num1, num2);
                break;
            case 3:
                answer = Product(num1, num2);
                break;
            case 4:
                answer = Quotient(num1, num2);
                break;
            case 5:
                answer = Fibonacci(num1, num2);
                break;
            default:
                throw new Exception("Invalid Menu Item selected");
        }

        // print output
        Console.WriteLine($"The result of the operation is: {answer}");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot divide by zero.");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
        Console.Clear();
    }
}


Console.WriteLine("********** - Thank you for using the sample calculator! - **********");


// Method Definitions
int AddNumbers(int num1, int num2)
{
    return num1 + num2;
}

int SubtractNumbers(int num1, int num2)
{
    return num1 - num2;
}

int Product(int num1, int num2)
{
    return num1 * num2;
}   

int Quotient(int num1, int num2)
{
    if (num2 == 0)
    {
        throw new DivideByZeroException("Cannot divide by zero.");
    }
    return num1 / num2;
}

int Fibonacci(int num1, int num2)
{
    var answer = 0;
    for (int i = num1; i <= num2; i++)
    {
        answer += i;
    }
    return answer;
}

void PrintMenu()
{
    Console.WriteLine("Please select an operation (-1 to exit)");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Fibonacci Sequence");
}