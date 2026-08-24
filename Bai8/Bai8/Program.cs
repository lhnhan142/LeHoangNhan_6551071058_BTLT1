namespace Bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Nhap phan tu thu {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("==== Các Phần tử trong mảng là: ====");
            for (int i = 0; i < arr.Length; i++) Console.WriteLine($"arr[{i}] = {arr[i]}");
            int sum = 0;
            for(int i = 0;i < arr.Length; i++) {
                sum += arr[i];
            }
            Console.WriteLine($"Tong = {sum}");
            float avg = (float)sum / arr.Length;
            Console.WriteLine($"Trung bình cộng = {avg:F2}");
            int max = arr[0], min = arr[0];
            int viTriMax = 0, viTriMin = 0;

            // Dùng vòng lặp for vì chúng ta cần biết vị trí (chỉ số i) của phần tử
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    viTriMax = i;
                }

                if (arr[i] < min)
                {
                    min = arr[i];
                    viTriMin = i;
                }
            }
            Console.WriteLine($"Giá trị lớn nhất: {max} (nằm ở vị trí index {viTriMax})");
            Console.WriteLine($"Giá trị nhỏ nhất: {min} (nằm ở vị trí index {viTriMin})");

            // 4. Số lượng phần tử chẵn, lẻ
            int soChan = 0, soLe = 0;
            foreach (int item in arr) // Dùng foreach vì chỉ cần xét giá trị
            {
                if (item % 2 == 0) soChan++;
                else soLe++;
            }
            Console.WriteLine($"Số lượng phần tử chẵn: {soChan}");
            Console.WriteLine($"Số lượng phần tử lẻ: {soLe}");

            // 5. Mảng sau khi đảo ngược thứ tự
            Array.Reverse(arr); // Hàm có sẵn của C# dùng để đảo ngược mảng
            Console.Write("Mảng sau khi đảo ngược: ");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
