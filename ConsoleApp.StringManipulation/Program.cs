// See https://aka.ms/new-console-template for more information
Console.WriteLine("******************** - String manipulation - ********************");

// Initialize with a  regular string literal
string s1 = "This is a literal string";
String s2 = "This is a literal string";
Console.WriteLine($"{nameof(s1)}: {s1}");
Console.WriteLine($"{nameof(s2)}: {s2}");

// Declare without initializing. (possible null exception)
string s3;
//Console.WriteLine($"{nameof(s3)}: {s3}"); // syntax error, s3 needs a value before it can be used.

// Initialize to null. (possible null exception)
string? s4 = null;
Console.WriteLine($"{nameof(s4)}: {s4}");

// initialize as an empty string.
string s5 = string.Empty;
string s6 = " ";
Console.WriteLine($"{nameof(s5)}: {s5}");
Console.WriteLine($"{nameof(s6)}: {s6}");

// Escape sequences and characters
// She said, "Hello World!"
string sentence = "She said, \"Hello World!\" \r\n This is the next line.";
Console.WriteLine($"{nameof(sentence)}: {sentence}");

// Verbatim string literal
string oldPath = "C:\\program file\\programfloder\\";
string newPath = @"C:\program file\programfloder\";
Console.WriteLine($"{nameof(oldPath)}: {oldPath}");
Console.WriteLine($"{nameof(newPath)}: {newPath}");

// User a const string to prevent modification to a string
const string path = "C:\\program file\\programfloder\\";
// path = "new valuew"; // Illegal operation, const cannot be modified
s1 = "A new string";
Console.WriteLine($"{nameof(path)}: {path}");
Console.WriteLine($"{nameof(s1)}: {s1}");

// Raw string literals
string rawLiteral = """" \sdfse ' "" This is literal string """";
string rawLiteral1 = """"
    She said, "Hello World!"
    This is the next line.
    And another line.

    """";
Console.WriteLine($"{nameof(rawLiteral)}: {rawLiteral}");
Console.WriteLine($"{nameof(rawLiteral1)}: {rawLiteral1}");

// Review concatenation and interpolation
s1 = s1 + s2;
s1 += s2;
string newString = $"{s1} {s2} some random literal text";
string newString1 = s1 + $"{s1} {s2} some random literal text";
string newString2 = String.Format("Literal: {0} {1} some random literal text", s1, s2);
Console.WriteLine($"{nameof(s1)}: {s1}");
Console.WriteLine($"{nameof(newString)}: {newString}");
Console.WriteLine($"{nameof(newString1)}: {newString1}");
Console.WriteLine($"{nameof(newString2)}: {newString2}");

/* String manipulation methods and properties. Sometimes it just assessment */

// Null or Empty check
// find the length of a string
Console.WriteLine($"{nameof(s1)} has a length of {s1.Length}");
Console.WriteLine($"{nameof(s6)} has a length of {s6.Length}");
//Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}"); // Will cause null exception


if (!string.IsNullOrEmpty(s4))
{
    Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}");
}
if(!string.IsNullOrEmpty(s5))
{
    Console.WriteLine($"{nameof(s5)} has a length of {s5.Length}");
}

// Substrings
string subString = s1.Substring(5);
Console.WriteLine($"{nameof(subString)}: {subString}");
subString = s1.Substring(5, 5);
Console.WriteLine($"{nameof(subString)}: {subString}");

// Splitting strings
var splitStrings = s2.Split(' ');
for (int i = 0; i < splitStrings.Length; i++)
{
    Console.WriteLine(splitStrings[i]);
}

// Replace
string replaements1 = s1.Replace('s', 'V');
Console.WriteLine($"{nameof(replaements1)}: {replaements1}");

string replaements2 = s1.Replace("string", "chicken");
Console.WriteLine($"{nameof(replaements2)}: {replaements2}");

// Convert to string
string salary = 342352334.23423.ToString();
int value = 123124;
string strValue = value.ToString();

// Changing Formatting
Console.WriteLine($"{nameof(salary)} : {salary:C}");
Console.WriteLine(nameof(salary) + " : " + value.ToString("C"));


// String comparison