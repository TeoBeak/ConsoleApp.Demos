// See https://aka.ms/new-console-template for more information
Console.WriteLine("************************** - Arrays - **************************");

// Tell me how many students and grades are to be entered
Console.Write("Please indicate the number of grades to be entered: ");
int numberOfGrades = Convert.ToInt32(Console.ReadLine());

// Delcare Fixed Size Array
int[] grades = new int[numberOfGrades];
string[] students = new string[numberOfGrades];
// Add values to Fixed Size Array
//grades[0] = 45;
//grades[1] = 67;
//grades[2] = 89;
//grades[3] = 90;
//grades[4] = 100;

for (int i = 0; i < numberOfGrades; i++)
{
    Console.Write($"Enter Student Name: ");
    students[i] = Console.ReadLine();

    Console.Write($"Enter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
} 
// Print vlaues in Fixed Size Array
Console.WriteLine("The Grades you have entered are: ");
for (int i = 0; i < numberOfGrades; i++)
{
    Console.WriteLine($"{students[i]}: {grades[i]}");
}

////Declare variable size array
//string[] studentNames = {"NewTon", "Einstein", "Curie"};

////Add values to variable size array
//for (int i = 0; i < studentNames.Length; i++)
//{
//    Console.Write($"Enter Student Name: ");
//    studentNames[i] = Console.ReadLine();
//}

//// Print values in variable size array
//Console.WriteLine("The Student Names you have entered are: ");
//for (int i = 0; i < studentNames.Length; i++)
//{
//    Console.WriteLine(studentNames[i]);
//}