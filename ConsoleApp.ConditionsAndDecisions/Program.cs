// See https://aka.ms/new-console-template for more information

// Prompt for input
Console.Write("Please enter student's grade: ");
// Global varuable / global scope
int grade = Convert.ToInt32(Console.ReadLine());

// Simple If Else statment - Decide to print pass or fail based on input
Console.WriteLine("************************ Simple IF Result ************************");
Console.WriteLine();

if (grade > 50)
{
    Console.WriteLine("Student has passed.");
}
else
{
    Console.WriteLine("Student has failed.");
    Console.WriteLine("Please recommend student to student affair's office.");
}
Console.WriteLine();
Console.WriteLine("************************ Simple IF Result End ************************");

Console.WriteLine();
Console.WriteLine();


// Complex If Else statment - Decide to print pass letter based on grade value
Console.WriteLine("************************ Complex IF ELSE IF Result ************************");
Console.WriteLine();

/*
 * A: 86 - 100
 * B: 75 - 84
 * C: 65 - 74
 * C-: 50 - 64
 * F: less than 50 X
 */

if (grade < 0 || grade > 100)
{
    Console.WriteLine("Invalid value entered. Please enter a grade between 0 and 100.");
}
else if (grade < 50)
{
    Console.WriteLine("Student has failed - F");
}
else if (grade >= 50 && grade <= 64)
{
    Console.WriteLine("C-");
}
else if (grade >= 65 && grade <= 74)
{
    Console.WriteLine("C");
}
else if (grade >= 75 && grade <= 84)
{
    Console.WriteLine("B");
}
else if (grade >= 85 && grade <= 100)
{
    Console.WriteLine("A - Good job");
}

int gradeAfterBonus = grade >= 0 && grade <= 100 ? grade + 10 : grade;
Console.WriteLine($"Grade after bonus: {gradeAfterBonus}"); 

Console.WriteLine();
Console.WriteLine("************************ Complex IF ELSE IF Result End ************************");

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("************************ Ternary Operator Result ************************");
Console.WriteLine();

string passStatus = grade < 50 ? "Fail" : "Pass";
Console.WriteLine($"Student status is: {passStatus}");

Console.WriteLine();
Console.WriteLine("************************ Ternary Operator Result End ************************");

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("************************ Switch Statement Result ************************");
Console.WriteLine();

/*
 * Write a program to accept an intger as  ther dat of the week adn print the appropriare message as outlined below.
 * 1 - Sunday
 * 2 - Monday
 * 3 - Tuesday
 * 4 - Wednesday (Hump Day!)
 * 5 - Thursday
 * 6 - Friday (TGIF!)
 * 7 - Saturday (Beach Day!) 
 */
Console.Write("Pleasr enter the day of the week: ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());

switch (dayOfTheWeek)
{
    case 1:
        Console.WriteLine("Sunday");
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wednesday");
        Console.WriteLine("(Hump Day!)");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday");
        Console.WriteLine("(TGIF!)");
        break;
    case 7:
        Console.WriteLine("Saturday");
        Console.WriteLine("(Beach Day!)");
        break;
    default:
        Console.WriteLine("Invalid day of the week entered. Please enter a number between 1 and 7.");
        break;
}

Console.WriteLine();
Console.WriteLine("************************ Switch Statement Result End ************************");

// The rest of the application
Console.WriteLine("Thank you for using this program.");