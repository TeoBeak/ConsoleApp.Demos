// See https://aka.ms/new-console-template for more information
//Console.WriteLine("******************** - DateTime manipulation - ********************");

//// Empty DateTime Object
//DateTime dateTime = new DateTime();

//// Create a DateTime from date and time
//var dateOfBirth = new DateTime(1990, 10, 17);
//Console.WriteLine($"My Dob is : {dateOfBirth}");

//var exactDateAndTimeOfBirth = new DateTime(1990, 10, 17, 21, 42, 25, DateTimeKind.Local);
//Console.WriteLine($"My Dob is : {exactDateAndTimeOfBirth}");
//Console.WriteLine($"Day of Week: {dateOfBirth.DayOfWeek}");
//Console.WriteLine($"Day of Year: {dateOfBirth.DayOfYear}");
//Console.WriteLine($"Time of Day: {exactDateAndTimeOfBirth.TimeOfDay}");
//Console.WriteLine($"Ticks: {exactDateAndTimeOfBirth.Ticks}");
//Console.WriteLine($"Kind: {exactDateAndTimeOfBirth.Kind}");

//// Create a DateTime from current timestamp
using System.Globalization;

DateTime now = DateTime.Now;
Console.WriteLine("The Time Now is: " + now);

// Create a DateTime from a string
Console.WriteLine("What is your DOB (MM/dd/yyyy): ");
string dob = Console.ReadLine();

var userDob = DateTime.Parse(dob);
Console.WriteLine($"Day of Week: {userDob.DayOfWeek}");
Console.WriteLine($"Day of Year: {userDob.DayOfYear}");
Console.WriteLine($"Time of Day: {userDob.TimeOfDay}");
Console.WriteLine($"Ticks: {userDob.Ticks}");
Console.WriteLine($"Kind: {userDob.Kind}");

// Change Format DateTime
Console.WriteLine($"Formatted Date: {userDob.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Formatted Date: {userDob.ToString("MMM, dd-yyyy")}");
Console.WriteLine($"Formatted Date: {userDob.ToString("dd-MMM-yyyy")}");
Console.WriteLine($"Formatted Date: {userDob:dddd, MMMM dd, yyyy}");


// Add Additional Time
Console.WriteLine("One hour from now is: " + now.AddHours(1));
Console.WriteLine("One day from now is: " + now.AddDays(1));
Console.WriteLine("One day ago from now is: " + now.AddDays(-1));


Console.WriteLine("******************** - DateTime offset manipulation - ********************");
// UTC - Coordinated Universal Time
var utcNow = DateTime.UtcNow;
Console.WriteLine($"Now Date Time: {now}");
Console.WriteLine($"UTC Now Date Time: {utcNow}");

// DateTimeOffset and TimeZond Info
var tz = TimeZoneInfo.Local.GetUtcOffset(utcNow);
Console.WriteLine($"user Time Zone: {tz}");

var dto = new DateTimeOffset(now, tz);
Console.WriteLine($"User Time Zone with UTC Offset: {dto}");
Console.WriteLine($"UTC Time of Action: {dto.UtcDateTime}");

var indiaTz = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
var IndiaDateTime = TimeZoneInfo.ConvertTimeFromUtc(dto.UtcDateTime, indiaTz);
Console.WriteLine($"Action was completed in India at : {IndiaDateTime}");


Console.WriteLine("******************** - Date only and Time only manipulation - ********************");
// DateOnly
var dateOnly = new DateOnly(1990, 10, 17);
var nextDay = dateOnly.AddDays(1);
var previousDay = dateOnly.AddDays(-1);
var decadeLater = dateOnly.AddYears(10);
var lastMonth = dateOnly.AddMonths(-1);

Console.WriteLine($"Date: {dateOnly}");
Console.WriteLine($"Next Day: {nextDay}");
Console.WriteLine($"Previous Day: {previousDay}");
Console.WriteLine($"Decade Later: {decadeLater}");
Console.WriteLine($"Last Month: {lastMonth}");

var dateOnlyFromDateTime = DateOnly.FromDateTime(now);
Console.WriteLine($"DateOnly from DateTime: {dateOnlyFromDateTime}");

Console.WriteLine("What is your DOB (dd MMM yyyy): ");
string dobDateOnly = Console.ReadLine();

var theDateOnly = DateOnly.ParseExact(dobDateOnly, "dd MMM yyyy", CultureInfo.InvariantCulture);
Console.WriteLine($"The DateOnly is: {theDateOnly}");

// TimeOnly
var timeNow = TimeOnly.FromDateTime(now);
Console.WriteLine($"Time Now: {timeNow}");
Console.WriteLine($"Time Now: {timeNow:hh:mm tt}");

// Date Comparison
var date1 = new DateOnly(1985, 11, 23);
var date2 = new DateOnly(1965, 1, 20);

Console.WriteLine($"Is '{nameof(date1)}' equal? {date1 == date2}");
Console.WriteLine($"Is '{nameof(date1)}' equal? {date1.Equals(date2)}");
Console.WriteLine($"Is {date2} after? {date2 > date1}");
Console.WriteLine($"Is {date2} before? {date2 < date1}");