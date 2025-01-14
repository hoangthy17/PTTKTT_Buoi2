﻿using System;

class MergeSort
{


    // Hàm sắp xếp merge sort
    static void Merge_Sort(int[] a, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            // Sắp xếp nửa đầu và nửa sau của mảng
            Merge_Sort(a, left, mid);
            Merge_Sort(a, mid + 1, right);

            // Trộn hai nửa đã sắp xếp
            Merge(a, left, mid, right);
        }
    }

    // Hàm trộn hai mảng con đã sắp xếp
    static void Merge(int[] a, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        // Tạo mảng tạm để lưu các phần tử
        int[] L = new int[n1];
        int[] R = new int[n2];

        // Sao chép dữ liệu vào mảng tạm
        for (int i = 0; i < n1; i++)
        {
            L[i] = a[left + i];
        }
        for (int j = 0; j < n2; j++)
        {
            R[j] = a[mid + 1 + j];
        }

        // Trộn mảng tạm vào mảng chính array[left..right]
        int k = left;
        int p = 0, q = 0;
        while (p < n1 && q < n2)
        {
            if (L[p] >= R[q])
            {
                a[k] = L[p];
                p++;
            }
            else
            {
                a[k] = R[q];
                q++;
            }
            k++;
        }

        // Sao chép các phần tử còn lại của L[] nếu có
        while (p < n1)
        {
            a[k] = L[p];
            p++;
            k++;
        }

        // Sao chép các phần tử còn lại của R[] nếu có
        while (q < n2)
        {
            a[k] = R[q];
            q++;
            k++;
        }
    }

    // Hàm in ra mảng
    static void InMang(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.Title = "Merge Sort";
        var numbers = new[] { 10, 3, 1, 7, 9, 2, 0 };

        // In ra dãy số chưa được sắp xếp
        Console.WriteLine("Truoc khi sap xep:");
        InMang(numbers);

        // Sắp xếp dãy số bằng thuật toán merge sort
        Merge_Sort(numbers, 0, numbers.Length - 1);

        // In ra dãy số đã được sắp xếp
        Console.WriteLine("\nSau khi sap xep:");
        InMang(numbers);

        Console.ReadKey(); // Chờ người dùng nhấn một phím trước khi đóng cửa sổ console
    }
}

