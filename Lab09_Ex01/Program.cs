using static System.Console;

class Program
{
    static void Main()
    {
        Person.name = "John Doe";  // กำหนดชื่อให้กับ Person
        WriteLine(Person.GetName());  // แสดงผลลัพธ์จาก GetName
    }
}

static class Person
{
    public static string? name;  // ประกาศตัวแปร name ของ Person

    public static string GetName()
    {
        return $"Hello from {name}";  // คืนค่าชื่อที่เก็บใน name
    }
}

