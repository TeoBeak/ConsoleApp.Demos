// See https://aka.ms/new-console-template for more information


// Simple For Loop Demo
// Print Hello World 10 times

Console.WriteLine("******************** - Simple for loop! - ********************");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Hello, World! - {i}");
}

Console.WriteLine("Loop complete!");

// Ask User how many times they wish to print hello world and print accordingly

/*
Console.Write("How many times would you like to print 'Hello, World!'? ");
int times = Convert.ToInt32(Console.ReadLine());
for ( int i = 0; i < times; i++)
{
    Console.WriteLine($"Hello, World! - {i + 1}");
}
*/

Console.WriteLine("******************** - Simple for loop complete! - ********************");

Console.WriteLine();
// While Loop Demo

Console.WriteLine("******************** - While loop - ********************");

int counter = 0;
while (counter < 10 )
{
    Console.WriteLine($"Hello, World! = {counter}");
    counter += 2;
}

// Ask the user for a number and find the total for each number that is entered. Print final sum when the user enters -1 to exit.

int sum = 0;
int num = 0;

while (num != -1)
{
    Console.Write("Please numbers to be summed up. (-1 to stop or exit): ");
    num = Convert.ToInt32(Console.ReadLine());
    // nested if statement
    if(num != -1)
    {
        sum += num;
    }
}

Console.WriteLine($"Your sum is: {sum}");

Console.WriteLine("******************** - While loop complete! - ********************");