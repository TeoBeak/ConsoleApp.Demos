// See https://aka.ms/new-console-template for more information

// Write a program that takes a user's age as input and prints it to ther screen. Display an error message if an invalid input is received.

try
{
    Console.Write("Enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Your age is: {age}");
}
catch (Exception)
{
    Console.WriteLine("Your age value was incorrect. Please enter a valid number.");
    //throw;
}
finally
{
    Console.WriteLine("Thank you for using the age input program.");
}