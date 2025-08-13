// Declear variables
using System.Globalization;

const int retirementAge = 65;

string? firstName = string.Empty;
string lastName = string.Empty;
int age;
DateOnly dob = new DateOnly();
decimal salary;
char gender = char.MinValue;
bool working = true;

// Prompt the user for input
Console.Write("Please enter your first name: ");
firstName = Console.ReadLine();

Console.Write("Please enter your last name: ");
lastName = Console.ReadLine();

Console.Write("Please enter your date of birth (dd/mm/yyyy): ");
dob = DateOnly.ParseExact(Console.ReadLine(), "dd/mm/yyyy", CultureInfo.InvariantCulture);
age = DateTime.Now.Year - dob.Year;

Console.Write("Please enter your salary: ");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter your gender (M of F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working? (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());

// Process the data
int workingYearsRemaining = retirementAge - age;
var estimatedRetirementDate = DateTime.Now.AddYears(workingYearsRemaining);

// Output the result to the user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Your Salary is: {salary.ToString("C")}");
Console.WriteLine($"Your Gender is: {gender}");
Console.WriteLine($"You are employed: {working}");
Console.WriteLine($"Number of working years remaining: {workingYearsRemaining}");
Console.WriteLine($"Estimated retirement year: {estimatedRetirementDate.Year}");