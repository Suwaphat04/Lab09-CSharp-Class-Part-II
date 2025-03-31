var a1 = new AAA();
var a2 = new AAA();
a1.b1 = 10;
AAA.b2 = 20;  // ใช้ชื่อคลาส AAA เพื่อเข้าถึง static member
a2.b1 = 30;
AAA.b2 = 40;  // ใช้ชื่อคลาส AAA เพื่อเข้าถึง static member

System.Console.WriteLine($"a1.b1 = {a1.b1}");
System.Console.WriteLine($"AAA.b2 = {AAA.b2}");  // ใช้ชื่อคลาส AAA เพื่อเข้าถึง static member
System.Console.WriteLine($"a2.b1 = {a2.b1}");
System.Console.WriteLine($"AAA.b2 = {AAA.b2}");  // ใช้ชื่อคลาส AAA เพื่อเข้าถึง static member

class AAA 
{
    public int b1;  // Instance member
    public static int b2;  // Static member
}
