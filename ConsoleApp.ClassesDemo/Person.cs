// See https://aka.ms/new-console-template for more information
// Define a class
using System.Security.Cryptography;

public class Person
{
    // Properties / Data Members
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }

    // Fields members
    private string _taxNumber;
    public void PrintFullName()
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName}");
    }

    public void PrintInitials()
    {
        var firstInitial = FirstName[0];
        var lastInitial = LastName[0];
        Console.WriteLine($"{firstInitial} {lastInitial}");
    }

    public void GgenerateTaxNumber()
    {
        _taxNumber = RandomNumberGenerator.GetInt32(100000,999999).ToString();
    }

    public string GetTaxNumber()
    {
        return _taxNumber;
    }
}