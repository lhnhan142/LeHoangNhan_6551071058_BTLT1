using System;
namespace Bai6;
class Program
{
    static void Main(String []args )
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int n;
        bool isNumber;
        do
        {
            Console.Write("Nhập số từ 1-9: ");
            String input = Console.ReadLine();
            isNumber = int.TryParse(input, out n);
            if (!isNumber || n < 1 || n > 9) ;
            {
                Console.WriteLine("Vui lòng nhập số từ 1-9");
            }
        }
        while (!isNumber || n < 1 || n > 9);
        Console.WriteLine("======= BẢNG CƯU CHƯƠNG =======");
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} == {n * i}");
        }    
    }
}