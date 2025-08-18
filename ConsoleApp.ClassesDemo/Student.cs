using System.Security.Cryptography;

namespace ConsoleApp.ClassesDemo
{
    public class Student : Person
    {
        public void GenerateStudentIdNumber()
        {
            _idNumber = "STU-" + GetRandomNumber();
        }
    }
}
