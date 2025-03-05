using System;

namespace BE_NET_Sessions1
{
    internal class Program
    {
        /* Bài 1: Viết chương trình C# để tính tổng, tích, hiệu của hai số */
        static int Tong(int a, int b) => a + b;
        static int Tich(int a, int b) => a * b;
        static int Hieu(int a, int b) => a - b;

        /* Bài 2: Giải phương trình bậc 1 và bậc 2 */
        static void GiaiPhuongTrinhBacHai()
        {
            Console.Write("\n--------------------------------------------------\n");
            Console.Write("Nhap a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)  
            {
                if (b == 0)
                {
                    Console.WriteLine(c == 0 ? "phuong trinh vo so nghiem" : "Phuong trinh vo nghiem");
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine($"Phuong trinh co nghiem: x = {x}");
                }
            }
            else  
            {
                double delta = b * b - 4 * a * c;
                Console.WriteLine($"Delta = {delta}");

                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem.");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"Phuong trinh co nghiem: x = {x}");
                }
                else
                {
                    double sqrtDelta = Math.Sqrt(delta);
                    double x1 = (-b + sqrtDelta) / (2 * a);
                    double x2 = (-b - sqrtDelta) / (2 * a);
                    Console.WriteLine($"Phuong trinh co 2 nghiem: x1 = {x1}, x2 = {x2}");
                }
            }
        }
        /*Bài 3: Viết chương trình C# để giải bài tập chuyển đổi độ C thành độ K và độ F*/
        static void ChuyenDoi()
        {
            Console.Write("Nhap do C: ");
            double a = double.Parse(Console.ReadLine());
            double f = a * 1.8 + 32;
            double k = a + 273.15;
            Console.Write($"Chuyen doi tu do C sang F:{f} ");
            Console.Write($"/nChuyen doi tu do C sang K:{k} ");
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap a: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nTong: {Tong(num1, num2)}");
            Console.WriteLine($"Tich: {Tich(num1, num2)}");
            Console.WriteLine($"Hieu: {Hieu(num1, num2)}");

            GiaiPhuongTrinhBacHai();
            ChuyenDoi();
        }
    }
}
