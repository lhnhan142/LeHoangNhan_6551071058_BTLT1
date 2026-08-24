namespace Bai9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập họ tên: ");
            String input = Console.ReadLine();
            Console.WriteLine("Độ dài chuỗi: " + input.Length);
            Console.WriteLine("Chuỗi in hoa: " + input.ToUpper());
            Console.WriteLine("Chuỗi in thường: " + input.ToLower());
            Console.WriteLine("Chuỗi sau khi xóa khoảng trắng: " + input.Trim());
            Console.WriteLine("Chuỗi có chứa từ 'Nguyen' không: " + input.Contains("Nguyen"));
            //Tách thành mảng từng từ theo dấu cách (Split), in từng từ trên một dòng dùng foreach
            Console.WriteLine("\nCác từ trong chuỗi sau khi tách:");

            // Dùng Trim() trước khi Split để xóa khoảng trắng 2 đầu
            // StringSplitOptions.RemoveEmptyEntries giúp loại bỏ các khoảng trắng thừa ở giữa các từ
            string[] mangTu = input.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string tu in mangTu)
            {
                Console.WriteLine(tu);
            }

            // Ghép lại bằng String.Join với dấu "-"
            string chuoiGhep = string.Join("-", mangTu);
            Console.WriteLine("\nChuỗi sau khi ghép nối bằng dấu '-': " + chuoiGhep);
        }
    }
}
