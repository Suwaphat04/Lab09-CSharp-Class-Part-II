StaticDemo.i = 123;
StaticDemo.f = 1234.56f;
StaticDemo.s = "Hello World!";
StaticDemo.PrintValues();

class StaticDemo
{
    public static int i;    // Static field
    public static float f;  // Static field
    public static string s; // Static field

    public static void PrintValues()  // Static method
    {
        System.Console.WriteLine($"Integer i: {i}, floating point f: {f}, string s: {s}");
    }
}

