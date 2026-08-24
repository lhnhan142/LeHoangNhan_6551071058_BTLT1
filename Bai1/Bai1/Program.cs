using System;

class Program
{
    static void Main(string[] args)
    {
        string hoTen;
        int tuoi;
        double chieuCao;
        float canNang;
        bool daTotNghiep;

        Console.Write("Nhập họ tên: ");
        hoTen = Console.ReadLine();

        Console.Write("Nhập tuổi: ");
        tuoi = int.Parse(Console.ReadLine());

        Console.Write("Nhập chiều cao (m): ");
        chieuCao = double.Parse(Console.ReadLine());

        Console.Write("Nhập cân nặng (kg): ");
        canNang = float.Parse(Console.ReadLine());

        Console.Write("Đã tốt nghiệp (true/false): ");
        daTotNghiep = bool.Parse(Console.ReadLine());

        Console.WriteLine("\n--- Thông tin ---");
        Console.WriteLine("MSSV: 651071058");
        Console.WriteLine("Họ tên: " + hoTen);
        Console.WriteLine("Tuổi: " + tuoi);
        Console.WriteLine("Chiều cao: " + chieuCao + " m");
        Console.WriteLine("Cân nặng: " + canNang + " kg");
        Console.WriteLine("Đã tốt nghiệp: " + daTotNghiep);

        Console.ReadKey();
    }
}