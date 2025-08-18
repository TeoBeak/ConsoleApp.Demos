// See https://aka.ms/new-console-template for more information
using ConsoleApp.ClassesDemo;

Console.WriteLine("************************* - Classes and Object - *************************");

// Define an object of type Person

Person person; // this wiil be null by default

Person baby = new Person();
baby.FirstName = "Thompson";
baby.LastName = "Theresa";
baby.DateOfBirth = new DateOnly(2023,10,29);

baby.PrintFullName();
baby.PrintInitials();
baby.GenerateTaxNumber();

var taxNumber = baby.GetTaxNumber();

Console.WriteLine($"Tax Number: {taxNumber}");

var person1 = new Person("Developer", "One" , new DateOnly(2000,10,29));
person1.PrintFullName();
person1.PrintInitials();

var person2 = new Person("Developer", "Two", "123456");
person2.PrintFullName();
person2.PrintInitials();
person2.GenerateTaxNumber();
var person2IdNumber = person2.GetIdNumber();
Console.WriteLine($"Person 2 ID Number: {person2IdNumber}");

var teacher = new Teacher();
teacher.FirstName = "Thompson";
teacher.LastName = "Theresa";
teacher.DateOfBirth = new DateOnly(2023, 10, 29);

teacher.PrintFullName();
teacher.PrintInitials();
teacher.GenerateTaxNumber();
var teacherTaxNumber = teacher.GetTaxNumber();
Console.WriteLine($"Teacher Tax Number: {teacherTaxNumber}");
teacher.GenerateTeacherIdNumber();
var teacherIdNumber = teacher.GetIdNumber();
Console.WriteLine($"Teacher ID Number: {teacherIdNumber}");


Student student = new();
student.FirstName = "Thompson";
student.LastName = "Theresa";
student.DateOfBirth = new DateOnly(2023, 10, 29);

student.PrintFullName();
student.PrintInitials();
student.GenerateTaxNumber();  
student.GenerateStudentIdNumber();
var studentIdNumber = student.GetIdNumber();
Console.WriteLine($"Student ID Number: {studentIdNumber}");

//Polygon polygon = new Polygon(); // Compiler error
Rectangle rectangle = new(10, 20);
var rectangleArea = rectangle.Area();
Console.WriteLine($"Rectangle Area: {rectangleArea}");

Square square = new(50);
var squareArea = square.Area();
Console.WriteLine($"Square Area: {squareArea}");