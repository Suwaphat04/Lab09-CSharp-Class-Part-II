using System;

Circle.PrintCircleArea(100);

class Circle
{
    const double PI = 3.14159;  // ค่าคงที่ PI
    public static void PrintCircleArea(double radius)
    {
        // ไม่สามารถเปลี่ยนค่าของ PI ได้ เพราะ PI เป็น const
        Console.WriteLine($"Radius = {radius}, Area = {PI * radius * radius}");
    }
}

