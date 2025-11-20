using System;

namespace Bai01
{
    internal class Program
    {
        // Tao mang mot chieu co n so ngau nhien
        static int[] CreateRandomArray()
        {
            int n; // So phan tu cua mang
            Console.Write("Nhap so phan tu cua mang: ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            // Tao cac so ngau nhen cho mang
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(-50, 51); // Tao so ngau nhien tu -50 den 50
            }

            return arr;
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        // Ham tra ve tong cac so le trong mang
        static long CalSumOfOddNumber(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0) sum += arr[i];
            }
            return sum;
        }

        // Ham kiem tra so nguyen to
        static bool IsPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return n > 1;
        }

        // Ham dem so nguyen to trong mang
        static int CountPrimeNumber(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]))
                    count++;
            }
            return count;
        }

        // Ham kiem tra so chinh phuong (la so n ma sqrt(n) va n deu la so nguyen)
        static bool IsPerfectSquare(int n)
        {
            if (n < 0) return false; // So am khong phai so chinh phuong
            int sqrt = (int)Math.Sqrt(n);
            return sqrt * sqrt == n;
        }

        // Ham tim so chinh phuong nho nhat
        static int FindSmallestPerfectSquareNum(int[] arr)
        {
            int smallestPerfecttSquareNum = -1;
            // Tim so chinh phuong dau tien
            int index;
            for (index = 0; index < arr.Length; index++)
            {
                if (IsPerfectSquare(arr[index]))
                {
                    smallestPerfecttSquareNum = arr[index];
                    break; // Tim duoc so thi dem so sanh voi cac so ke tiep
                }
            }
            if (smallestPerfecttSquareNum == -1)
                return smallestPerfecttSquareNum;

            for (int i = index + 1; i < arr.Length; i++)
            {
                if (IsPerfectSquare(arr[i]) && arr[i] < smallestPerfecttSquareNum)
                    smallestPerfecttSquareNum = arr[i];
            }

            return smallestPerfecttSquareNum;
        }
        static void Main(string[] args)
        {
            // Tao va in cac phan tu trong mang ngau nhien
            int[] newArr = CreateRandomArray();
            Console.Write("Cac phan tu trong mang la: ");
            PrintArray(newArr);

            // a. Tinh cac tong so le trong mang
            long sumOdd = CalSumOfOddNumber(newArr);
            Console.WriteLine("Tong cac so le trong mang: " + sumOdd);


            // b. Dem so nguyen to trong mang
            int countPrime = CountPrimeNumber(newArr);
            Console.WriteLine("So nguyen to trong mang la: " + countPrime);

            // c. Tim so chinh phuong nho nhat (return -1 neu ko co)
            int smallestPerfectSquareNum = FindSmallestPerfectSquareNum(newArr);
            Console.WriteLine("So chinh phuong nho nhat trong mang la: " +  smallestPerfectSquareNum);
        }
    }
}
