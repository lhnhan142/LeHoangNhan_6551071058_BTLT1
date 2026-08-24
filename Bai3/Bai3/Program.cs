using System;

class Program
{
    static void Main(string[] args)
    {
        double celsius;

        Console.Write("Nhập nhiệt độ Celsius: ");
        celsius = double.Parse(Console.ReadLine());

        double fahrenheit = celsius * 9 / 5 + 32;
        double kelvin = celsius + 273.15;

        Console.WriteLine("\n===== CHUYỂN ĐỔI NHIỆT ĐỘ =====");
        Console.WriteLine("MSSV: 6551071058");
        Console.WriteLine("Celsius: " + celsius + " °C");
        Console.WriteLine("Fahrenheit: " + fahrenheit + " °F");
        Console.WriteLine("Kelvin: " + kelvin + " K");

        Console.ReadKey();
    }
}