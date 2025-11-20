using System;

namespace Bai04
{
    public class Date
    {
        int day, month, year;
        public Date(int d = 1, int m = 1, int y = 1)
        {
            this.day = d;
            this.month = m;
            this.year = y;
        }

        // Ham kiem tra nam nhuan
        bool IsLeapYear()
        {
            if (this.year % 400 == 0 || (this.year % 100 != 0 && this.year % 4 == 0))
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

        // Kiem tra xem ngay thang nam co hop le hay khong, neu khong thi thoat chuong trinh
        public void CheckInput()
        {
            if (!this.IsValidDate())
            {
                Console.WriteLine("Ngay thang nam khong hop le!");
                Environment.Exit(0);
            }
        }

        // Ham tra ve so ngay trong thang do
        public int DaysInMonth()
        {
            int[] daysInMonth = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (this.IsLeapYear()) daysInMonth[1] = 29; // Nam nhuan thi thang 2 co 29 ngay

            return daysInMonth[month - 1];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap thang va nam: ");
            int month, year;
            Console.Write("Nhap thang: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            year = int.Parse(Console.ReadLine());

            Date date = new Date(1, month, year);
            date.CheckInput();

            Console.WriteLine("So ngay trong thang {0} nam {1} la: " + date.DaysInMonth(), month, year);
        }
    }
}


