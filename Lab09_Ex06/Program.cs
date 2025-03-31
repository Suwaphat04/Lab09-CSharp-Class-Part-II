Circle.PrintCircleArea(100);

class Circle
{
    const double PI = 3.14159;
    
    public static void PrintCircleArea(double radius)  // ใช้ static แทน statix
    {
        System.Console.WriteLine($"Radius = {radius}, Area = {PI * radius * radius}");  // ใช้ Console.WriteLine
    }
}

