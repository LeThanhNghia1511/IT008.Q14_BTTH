using System;

namespace Bai03
{
    class Date
    {
        int day, month, year;
        public Date(int d = 1, int m = 1, int y = 1)
        {
            this.day = d;
            this.month = m;
            this.year = y;
        }

        // Ham nhap ngay thang nam
        public void Input()
        {
            Console.WriteLine("Nhap ngay thang nam: ");
            Console.Write("Nhap ngay: ");
            this.day = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            this.month = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            this.year = int.Parse(Console.ReadLine());
        }

        // Ham xuat ngay thang nam
        public void Output()
        {
            Console.WriteLine("Ngay thang nam da nhap la: {0}/{1}/{2}", this.day, this.month, this.year);
        }

        // Ham kiem tra nam nhuan
        bool IsLeapYear()
        {
            if (year % 400 == 0 || (year % 100 != 0 && year % 4 == 0))
                return true;
            return false;
        }

        // Ham kiem tra ngay thang nam hop le
        public bool IsValidDate()
        {
            int[] daysInMonth = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (this.IsLeapYear()) daysInMonth[1] = 29; // Nam nhuan thi thang 2 co 29 ngay

            if (this.day < 1 || this.month < 1 || this.year < 1) // => Tat ca deu lon hon 1
                return false;
            else if (this.month > 12 || this.day > daysInMonth[this.month - 1])
                return false;
            return true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date();
            date.Input();
            date.Output();

            if (date.IsValidDate())
            {
                Console.WriteLine("Hop le!");
            }
            else Console.WriteLine("Khong hop le!");
        }
    }
}
