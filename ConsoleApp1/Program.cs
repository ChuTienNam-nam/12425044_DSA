using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
class program
{
    public static long Bai1(int n)
    {
        if (n == 1)
            return 1;
        return Bai1(n - 1) + n;
    }
    public static long Bai2(int n)
    {
        if (n == 1)
            return 1;
        return Bai2(n - 1) + n * n;
    }
    public static double Bai3(int n)
    {
        if (n == 1)
            return 1;
        return Bai3(n - 1) + 1 / n;
    }
    public static double Bai4(double x, int n)
    {
        if (n == 0)
            return 1;
        return Bai4(x, n - 1) * x;
    }
    public static double Bai5(int n)
    {
        if (n % 2 != 0)
            return n;
        return Bai5(n / 2);
    }
    public static double Bai6(int a, int b)
    {
        if (a % b == 0)
            return b;
        return Bai6(b, a % b);
    }
    public static double Bai7(int n)
    {
        if (n == 0)
            return 0;
        return Bai7(n / 10) + 1;
    }
    static double Can(int i, int n)
    {
        if (i == n) return Math.Sqrt(n);
        return Math.Sqrt(i + Can(i + 1, n));
    }

    static double Bai8(int n)
    {
        if (n <= 0) return 0;
        return Can(1, n);
    }
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; 

        Console.WriteLine("Bài tập chương 3");
        Console.WriteLine("1. Bài 1: Tính S(n) = 1 + 2 + ... + n");
        Console.WriteLine("2. Bài 2: Tính S(n) = 1^2 + 2^2 + ... + n^2");
        Console.WriteLine("3. Bài 3: Tính S(n) = 1 + 1/2 + ... + 1/n");
        Console.WriteLine("4. Bài 4: Tính x^n");
        Console.WriteLine("5. Bài 5: Tìm ước số lẻ lớn nhất");
        Console.WriteLine("6. Bài 6: Ước chung lớn nhất (UCLN)");
        Console.WriteLine("7. Bài 7: Đếm số chữ số");
        Console.WriteLine("8. Bài 8: Tính căn lồng nhau");
        Console.Write("\n Chọn bài tập muốn chạy 1 -> 8: ");

        int chon = int.Parse(Console.ReadLine() ?? "1");

        Console.WriteLine("\n Kết quả ");
        switch (chon)
        {
            case 1:
                Console.WriteLine($"Bài 1: S(5) = {Bai1(5)}");
                break;
            case 2:
                Console.WriteLine($"Bài 2: S(3) = {Bai2(3)}");
                break;
            case 3:
                Console.WriteLine($"Bài 3: S(3) = {Bai3(3):F4}");
                break;
            case 4:
                Console.WriteLine($"Bài 4: S(2, -3) = {Bai4(2, -3)}");
                break;
            case 5:
                Console.WriteLine($"Bài 5: Ước lẻ lớn nhất của 100 = {Bai5(100)}");
                break;
            case 6:
                Console.WriteLine($"Bài 6: UCLN(48, 18) = {Bai6(48, 18)}");
                break;
            case 7:
                Console.WriteLine($"Bài 7: Số chữ số của 12345 = {Bai7(12345)}");
                break;
            case 8:
                Console.WriteLine($"Bài 8: S(3) = {Bai8(3):F4}");
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ!");
                break;
        }
    }
}

