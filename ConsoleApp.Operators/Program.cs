// See https://aka.ms/new-console-template for more information

Console.Write("Pleasr enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int num2 = 0;
Console.Write("Pleasr enter the second number: ");
string numberEntered = Console.ReadLine();
num2 = Convert.ToInt32(numberEntered);

/*
 * Math Operations
 */
// Add numbers
int sum = num1 + num2;
// multiply 
int product = num1 * num2;
// Division
int quotient = num1 / num2;
// Subtraction
int difference = num1 - num2;
// Modulus
int mod = num1 % num2;

Console.WriteLine("************************** Math Results **************************");
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine();
Console.WriteLine("************************ End Math Results ************************");

/*
 * Logical Operators
 */

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqualTo = num1 != num2;

Console.WriteLine("************************ Logical Results ************************");
Console.WriteLine();
Console.WriteLine($"Is Greater Than: {isGreaterThan}");
Console.WriteLine($"Is Less Than: {isLessThan}");
Console.WriteLine($"Is Equal To: {isEqualTo}");
Console.WriteLine($"Is Greater Than Or Equal To: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is Less Than Or Equal To: {isLessThanOrEqualTo}");
Console.WriteLine($"Is Not Equal To: {isNotEqualTo}");
Console.WriteLine();
Console.WriteLine("************************ End Logical Results ************************");

/*
 * Assignment Operators
 */
Console.Write("Enter Random value for assignment operations: ");
int randomValue = Convert.ToInt32(Console.ReadLine());
//int increseValue = num1 + 5;

//num1 = num1 + 5;

Console.WriteLine("************************ Assignment Results ************************");
Console.WriteLine();
num1 += randomValue;
Console.WriteLine($"Num1 increaseed by {randomValue}: {num1}");
num1 -= randomValue;
Console.WriteLine($"Num1 decreased by {randomValue}: {num1}");
num1 /= randomValue;
Console.WriteLine($"Num1 divided by {randomValue}: {num1}");
num1 &= randomValue;
Console.WriteLine($"Num1 mod by {randomValue}: {num1}");
num1 *= randomValue;
Console.WriteLine($"Num1 multiplied by {randomValue}: {num1}");
Console.WriteLine();
Console.WriteLine("************************ End Assignment Results ************************");