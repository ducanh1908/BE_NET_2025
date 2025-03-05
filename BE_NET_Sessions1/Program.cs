namespace BE_NET_Sessions1
{
    internal class Program
    {
         static int Tong(int a, int b)
        {
            return a + b;
        }
        static int Tich(int a, int b)
        {
            return a * b;
        }
        static int Hieu(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int num2 = int.Parse(Console.ReadLine());
            int Tong2So = Tong(num1, num2);
            int Tich2So = Tich(num1, num2);
            int Hieu2So = Hieu(num1, num2);

            Console.WriteLine("Tong cua 2 so la:" +Tong2So );
            Console.WriteLine("Tich cua 2 so la:" + Tich2So);
            Console.WriteLine("Hieu cua 2 so la:" + Hieu2So);
        }
    }
}