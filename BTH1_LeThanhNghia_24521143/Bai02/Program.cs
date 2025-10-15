using System;

namespace Bai02
{
    internal class Program
    {

        // Ham kiem tra so nguyen to 
        static bool IsPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return n > 1;
        }

        // Ham tinh tong cac so nguyen to be hon n
        static long CalSumOfPrimeNum(int n)
        {
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (IsPrime(i))
                    sum += (long)i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());

            long sumPrimNum = CalSumOfPrimeNum(n);
            Console.WriteLine("Tong cac so nguyen to nho hon n la: " + sumPrimNum);
        }
    }
}
