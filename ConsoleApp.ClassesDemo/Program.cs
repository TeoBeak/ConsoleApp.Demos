// See https://aka.ms/new-console-template for more information
Console.WriteLine("************************* - Classes and Object - *************************");

// Define an object of type Person

Person person; // this wiil be null by default

Person baby = new Person();
baby.FirstName = "Thompson";
baby.LastName = "Theresa";
baby.DateOfBirth = new DateOnly(2023,10,29);

baby.PrintFullName();
baby.PrintInitials();
baby.GgenerateTaxNumber();

var taxNumber = baby.GetTaxNumber();

Console.WriteLine($"Tax Number: {taxNumber}");