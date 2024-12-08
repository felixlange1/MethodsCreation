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
    // which then get multiplied by each other and by 0.5. I used 'baseX' as a variable name for the base,
    // since it didn't seem to accept 'base':
    public static double TriangleArea(double height, double baseX)
    {
        return 0.5 * height * baseX;
    }
}

