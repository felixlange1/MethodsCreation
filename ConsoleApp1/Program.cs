namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    
    // Method for calculating area of a circle, accepting a radius as parameter:
    public static double CircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }
    
    // Method for calculating area of a triangle, accepting parameters for height and base of the triangle,
    // which then get multiplied by each other and by 0.5:
    public static double TriangleArea(double height, double baseLength)
    {
        return 0.5 * height * baseLength;
    }
}

