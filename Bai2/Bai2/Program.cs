using System;

class Program
{
    static void Main(string[] args)
    {
        double a, b;

        Console.Write("Nhập số a: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Nhập số b: ");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine("\n===== MÁY TÍNH ĐƠN GIẢN =====");
        Console.WriteLine("MSSV: 6551071058");

        Console.WriteLine("Cộng: " + (a + b));
        Console.WriteLine("Trừ: " + (a - b));
        Console.WriteLine("Nhân: " + (a * b));

        if (b != 0)
        {
            Console.WriteLine("Chia: " + (a / b));
            Console.WriteLine("Chia lấy phần nguyên: " + ((int)a / (int)b));
            Console.WriteLine("Chia lấy phần dư: " + ((int)a % (int)b));
        }
        else
        {
            Console.WriteLine("Chia: Không thể chia cho 0");
            Console.WriteLine("Chia lấy phần nguyên: Không thể chia cho 0");
            Console.WriteLine("Chia lấy phần dư: Không thể chia cho 0");
        }

        Console.WriteLine("Lũy thừa a^b: " + Math.Pow(a, b));

        Console.ReadKey();
    }
}