namespace ConsoleApp.ClassesDemo
{
    public class Rectangle : Polygon
    {
        public Rectangle(int width, int length)
        {
            Width = width;
            Length = length;
        }
        public int Length { get; set; }
        public override int Area()
        {
            return Length * Width;
        }
    }
}
