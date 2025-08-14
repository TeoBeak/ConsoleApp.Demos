// See https://aka.ms/new-console-template for more information
Console.WriteLine("***************** - Methods - *****************");

// void methods - complete a task without returning a value
void PrintName()
{
    // Method code 
    Console.WriteLine("Teo Baek");
}

// value returning methods - returns a value after an operation
int GetFiveYearsAgo()
{
    int year = DateTime.Now.AddYears(-5).Year;
    return year;
}

// methods with parameters
void PrintNameWithParams(string name)
{
    // Method code 
    Console.WriteLine("Your name is " + name);
}
int GetYearDifferenceWithParams(int year)
{
    int yearDifference = DateTime.Now.Year - year;
    return yearDifference;
}

// methods with optional parameters
int GetGutureOrPastYear(int numberOfYears = 0)
{
    var year = DateTime.Now.AddYears(numberOfYears).Year;
    return year;
}

// methods with nullable parameters
void PrintNameNullableParams(string? name, int? count)
{
    //if(string.IsNullOrEmpty(name))
    //{
    //    name = "Default Name";
    //}
    //if(!count.HasValue)
    //{
    //    count = 1;
    //}

    name ??= "Default Name";
    count ??= 1;

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(name);
    }
}



/* Function Calls */
PrintName();
int fiveYearsAgo = GetFiveYearsAgo();
Console.WriteLine($"Five years ago was: {fiveYearsAgo}");

Console.Write("Enter your name: ");
string name1 = Console.ReadLine();
PrintNameWithParams(name1);

Console.Write("Enter a year: ");
int pastYear = Convert.ToInt32(Console.ReadLine());
int yearDifference = GetYearDifferenceWithParams(pastYear);
Console.WriteLine($"This was " + yearDifference + " year ago");

Console.WriteLine("Enter a number of year in the future or past");
int numberOfYears = Convert.ToInt32(Console.ReadLine());

var pastYear1 = GetGutureOrPastYear();
Console.WriteLine("The year is: " + pastYear1);

var pastYear2 = GetGutureOrPastYear(numberOfYears);
Console.WriteLine("The year is: " + pastYear2);

PrintNameNullableParams(null, null);
PrintNameNullableParams("Teo Baek", 5);