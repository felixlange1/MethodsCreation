namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // Getting user input for the radius of the circle. Then parsing the input value (a string) so it becomes a double,
        // before calling the CircleArea method. The same concept is used for the other methods.
        Console.WriteLine("To calculate the area of a circle, please enter the radius:");
        string inputRadius = Console.ReadLine();
        double radius = double.Parse(inputRadius);
        Console.WriteLine("The area of your circle is " + (CircleArea(radius)));
        
        Console.WriteLine("To calculate the area of a triangle, please enter height:");
        string inputHeight = Console.ReadLine();
        double height = double.Parse(inputHeight);
        Console.WriteLine("Now enter the length of the base:");
        string inputBase = Console.ReadLine();
        double baseLength = double.Parse(inputBase);
        Console.WriteLine("The area of your triangle is " + (TriangleArea(height, baseLength)));
        
        Console.WriteLine("To calculate the area of a rectangle, please first enter the width:");
        string inputWidth = Console.ReadLine();
        double width = double.Parse(inputWidth);
        Console.WriteLine("Now enter the length:");
        string inputLength = Console.ReadLine();
        double length = double.Parse(inputLength);
        Console.WriteLine("The area of your rectangle is " + (RectangleArea(length, width)));
        
        Console.WriteLine("To calculate the area of a square, please enter the length of the side:");
        string inputSide = Console.ReadLine();
        double side = double.Parse(inputSide);
        Console.WriteLine("The area of your square is " + (SquareArea(side)));
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


    // Method for calculating the area of a rectangle, accepting 2 parameters for length and width:
    public static double RectangleArea(double length, double width)
    {
        return length * width;
    }

    // Method for calculating the area of a rectangle, accepting 2 parameters for length and width:
    public static double SquareArea(double side)
    {
        return side * side;
    }
    
    
}