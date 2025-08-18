namespace ConsoleApp.ClassesDemo
{
    public class Teacher : Person
    {
        public void GenerateTeacherIdNumber()
        {
            _idNumber = "TCH-" + GetRandomNumber();
        }
    }
}
