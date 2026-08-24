using System;
namespace Bai7;
class Program
{
    static void Main(String[] args)
    {
        Console.Write("Nhập n: ");
        String input = Console.ReadLine();
        int n = int.Parse(input);
        int tong = 0, tongChan = 0, tongLe = 0;
        long giaiThua = 1;
        for(int i = 1; i <= n; i++)
        {
            giaiThua *= i;
            tong += i;
            if (i % 2 == 0)
            {
                tongChan += i;
            }
            else
            {
                tongLe += i;
            }
        }
        Console.WriteLine("===== Kết quả =====");
        Console.WriteLine("Tổng các số từ 1 đến n: {0}", tong);
        Console.WriteLine("Tổng các số chẵn từ 1 đến n: {0}", tongChan);
        Console.WriteLine("Tổng các số lẻ từ 1 đến n: {0}", tongLe);
        Console.WriteLine("Giai thừa của n: {0}", giaiThua);
    }
}