using System;

namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        { 
            int n = 0;
            bool nhapHopLe = false;

            // Dùng vòng lặp while để ép người dùng nhập đúng số và trong khoảng quy định
            while (!nhapHopLe)
            {
                Console.Write("Nhập vào số nguyên dương n (n <= 1000): ");

                // Khối try-catch để bắt lỗi (Exception)
                try
                {
                    // Lệnh Parse sẽ văng ra lỗi FormatException nếu người dùng nhập chữ
                    n = int.Parse(Console.ReadLine());

                    if (n <= 0 || n > 1000)
                    {
                        Console.WriteLine("Lỗi: Số n phải lớn hơn 0 và nhỏ hơn hoặc bằng 1000. Vui lòng nhập lại!\n");
                    }
                    else
                    {
                        nhapHopLe = true; // Dữ liệu đúng, thoát vòng lặp while
                    }
                }
                catch (FormatException)
                {
                    // Bắt lỗi khi người dùng nhập chữ cái hoặc ký tự đặc biệt
                    Console.WriteLine("Lỗi định dạng: Bạn phải nhập một số nguyên, không được nhập chữ hay ký tự!\n");
                }
            }

            Console.WriteLine($"\n--- CÁC SỐ NGUYÊN TỐ TỪ 2 ĐẾN {n} ---");

            int tongSoNguyenTo = 0; // Biến đếm số lượng số nguyên tố

            // VÒNG LẶP FOR LỒNG NHAU
            // Vòng lặp ngoài: Duyệt các số từ 2 đến n để kiểm tra
            for (int i = 2; i <= n; i++)
            {
                bool laSoNguyenTo = true;

                // Vòng lặp trong: Kiểm tra xem số i có chia hết cho số nào từ 2 đến (i - 1) không
                // Mẹo tối ưu: Chỉ cần chạy j tới i/2 (hoặc căn bậc 2 của i) là đủ để xác định, 
                // nhưng ở đây chạy đến j < i cho sát với tư duy lồng nhau cơ bản.
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0) // Nếu i chia hết cho một số j bất kỳ
                    {
                        laSoNguyenTo = false; // Đánh dấu không phải số nguyên tố
                        break; // Thoát vòng lặp trong ngay lập tức để tiết kiệm thời gian
                    }
                }

                // Nếu sau khi chạy vòng lặp trong mà biến laSoNguyenTo vẫn là true
                if (laSoNguyenTo)
                {
                    Console.Write(i + " "); // In số nguyên tố đó ra
                    tongSoNguyenTo++;       // Tăng biến đếm lên 1
                }
            }

            // In tổng kết
            Console.WriteLine($"\n\nTổng cộng có: {tongSoNguyenTo} số nguyên tố.");

            // Dừng màn hình
            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}