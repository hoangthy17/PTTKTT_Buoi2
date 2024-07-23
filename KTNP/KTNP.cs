using System;

class BinarySearchExample
{
    // Hàm tìm kiếm nhị phân
    public static int BinarySearch(int[] a, int t)
    {
        int left = 0;               // Chỉ số bắt đầu của mảng
        int right = a.Length - 1; // Chỉ số kết thúc của mảng

        while (left <= right)
        {
            // Tính toán chỉ số giữa
            int mid = left + (right - left) / 2;

            // Kiểm tra nếu phần tử giữa là phần tử cần tìm
            if (a[mid] == t)
            {
                return mid; // Trả về chỉ số của phần tử nếu tìm thấy
            }

            // Nếu phần tử cần tìm lớn hơn phần tử giữa, bỏ qua nửa trái
            if (a[mid] < t)
            {
                left = mid + 1;
            }
            // Nếu phần tử cần tìm nhỏ hơn phần tử giữa, bỏ qua nửa phải
            else
            {
                right = mid - 1;
            }
        }

        return -1; // Trả về -1 nếu không tìm thấy phần tử
    }

    // Hàm chính để chạy chương trình
    static void Main(string[] args)
    {
        // Khởi tạo mảng đã được sắp xếp
        int[] a = { 3, 9, 10, 27, 38, 43, 82 };
        int t = 43; // Phần tử cần tìm

        // In ra mảng đã sắp xếp và phần tử cần tìm
        Console.WriteLine("Mang đa sap xep: " + string.Join(", ", a));
        Console.WriteLine("Phan tu can tim: " + t);

        // Gọi hàm BinarySearch để tìm phần tử trong mảng
        int index = BinarySearch(a, t );

        // In ra kết quả tìm kiếm
        if (index != -1)
        {
            Console.WriteLine("Phan tu " + t + " đuoc tim thay tai chi so: " + index);
        }
        else
        {
            Console.WriteLine("Phan tu " + t + " khong co trong mang.");
        }
    }
}