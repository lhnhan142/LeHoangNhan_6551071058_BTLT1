using System;

class Program
{
    static void Main(string[] args)
    {
        int so;

        Console.Write("Nhập một số nguyên: ");
        so = int.Parse(Console.ReadLine());

        Console.WriteLine("\n===== KIỂM TRA SỐ =====");
        Console.WriteLine("MSSV: 6551071058");

        // Kiểm tra dương, âm hoặc bằng 0
        if (so > 0)
        {
            Console.WriteLine("Số đó là số dương.");
        }
        else if (so < 0)
        {
            Console.WriteLine("Số đó là số âm.");
        }
        else
        {
            Console.WriteLine("Số đó bằng 0.");
        }

        // Kiểm tra chẵn hoặc lẻ
        if (so % 2 == 0)
        {
            Console.WriteLine("Số đó là số chẵn.");
        }
        else
        {
            Console.WriteLine("Số đó là số lẻ.");
        }

        // Kiểm tra chia hết cho 3
        if (so % 3 == 0)
        {
            Console.WriteLine("Số đó chia hết cho 3.");
        }
        else
        {
            Console.WriteLine("Số đó không chia hết cho 3.");
        }

        // Kiểm tra chia hết cho cả 2 và 3
        if (so % 2 == 0 && so % 3 == 0)
        {
            Console.WriteLine("Số đó chia hết cho cả 2 và 3.");
        }
        else
        {
            Console.WriteLine("Số đó không chia hết cho cả 2 và 3.");
        }

        Console.ReadKey();
    }
}