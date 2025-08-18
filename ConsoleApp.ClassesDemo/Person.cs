// See https://aka.ms/new-console-template for more information
// Define a class
using System.Security.Cryptography;

public class Person
{
    public Person() { }

     public Person(string firstName, string lastName, DateOnly dob)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dob;
    }

    public Person(string firstName, string lastName, string taxNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        _taxNumber = taxNumber;
    }

    // Properties / Data Members
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }

    // Fields members
    private string _taxNumber;
    protected string _idNumber = "N/A";

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

    public void GenerateTaxNumber()
    {
        if (string.IsNullOrEmpty(_taxNumber))
        {
            _taxNumber = GetRandomNumber();
        }
        else
        {
            Console.WriteLine($"Tax number already exists for {FirstName} {LastName}.");
        }
    }

    public string GetTaxNumber()
    {
        return _taxNumber;
    }

    public string GetIdNumber()
    {
        return _idNumber;
    }

    public int GetAge()
    {
        var age = DateTime.Now.Year - DateOfBirth.Year;
        return age;
    }

    public int GetAge(int year)
    {
        var age = year - DateOfBirth.Year;
        return age;
    }
    protected string GetRandomNumber()
    {
        return RandomNumberGenerator.GetInt32(100000, 999999).ToString();
    }
}