using System;

class Program
{
    static long MultiplyRecursive(long a, long b)
    {
        // Kiểm tra nếu một trong hai số bằng 0
        if (a == 0 || b == 0)
        {
            return 0;
        }

        // Kiểm tra nếu một trong hai số là số âm
        bool isNegative = false;
        if (a < 0)
        {
            a = Math.Abs(a);
            isNegative = true;
        }
        if (b < 0)
        {
            b = Math.Abs(b);
            isNegative = true;
        }

        // Nhân hai số bằng cách đệ quy
        long result;
        if (b == 1)
        {
            result = a;
        }
        else
        {
            result = a + MultiplyRecursive(a, b - 1);
        }

        // Xử lý trường hợp số âm
        if (isNegative)
        {
            result = -result;
        }

        // Trả về kết quả
        return result;
    }
    static void Main(string[] args)
    {
        // Nhập hai số nguyên
        Console.WriteLine("Nhap mang 1 :");
        long a = long.Parse(Console.ReadLine());
        Console.WriteLine("Nhap mang 2 :");
        long b = long.Parse(Console.ReadLine());

        // Nhân hai số bằng thuật toán đệ quy
        long result = MultiplyRecursive(a, b);

        // In kết quả ra màn hình
        Console.WriteLine("Ket qua: " + result);
    }
}

