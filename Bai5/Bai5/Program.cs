using System;

class Program
{
    static void Main(string[] args)
    {
        double diem;

        Console.Write("Nhập điểm trung bình: ");
        diem = double.Parse(Console.ReadLine());

        Console.WriteLine("\n===== XẾP LOẠI HỌC SINH =====");
        Console.WriteLine("MSSV: 6551071058");

        if (diem < 0 || diem > 10)
        {
            Console.WriteLine("Điểm không hợp lệ!");
        }
        else if (diem >= 9.0)
        {
            Console.WriteLine("Xếp loại: Xuất sắc");
        }
        else if (diem >= 8.0)
        {
            Console.WriteLine("Xếp loại: Giỏi");
        }
        else if (diem >= 6.5)
        {
            Console.WriteLine("Xếp loại: Khá");
        }
        else if (diem >= 5.0)
        {
            Console.WriteLine("Xếp loại: Trung bình");
        }
        else
        {
            Console.WriteLine("Xếp loại: Yếu");
        }

        Console.ReadKey();
    }
}