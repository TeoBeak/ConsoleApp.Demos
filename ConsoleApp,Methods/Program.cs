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

// methods with optional parameters

// methods with nullable parameters

/* Function Calls */
PrintName();
int fiveYearsAgo = GetFiveYearsAgo();
Console.WriteLine($"Five years ago was: {fiveYearsAgo}");