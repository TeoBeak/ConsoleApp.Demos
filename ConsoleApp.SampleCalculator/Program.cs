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
        Console.WriteLine("Please select an operation (-1 to exit)");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Fibonacci Sequence");

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
                answer = num1 + num2;
                break;
            case 2:
                answer = num1 - num2;
                break;
            case 3:
                answer = num1 * num2;
                break;
            case 4:
                answer = num1 / num2;
                break;
            case 5:
                for (int i = num1; i <= num2; i++)
                {
                    answer += i;
                }
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