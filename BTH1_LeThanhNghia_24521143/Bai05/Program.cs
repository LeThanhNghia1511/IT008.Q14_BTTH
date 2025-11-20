using System;

namespace Bai05
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
            this.CheckInput();
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

        // Kiem tra xem ngay thang nam co hop le hay khong, neu khong thi gan mac dinh la 1/1/1
        public void CheckInput()
        {
            if (!this.IsValidDate())
            {
                Console.WriteLine("Ngay thang nam khong hop le!");
                this.day = 1;
                this.month = 1;
                this.year = 1;
            }
        }

        // Ham xuat ngay thang nam
        public void Output()
        {
            Console.WriteLine("Ngay thang nam da nhap la: {0}/{1}/{2}", this.day, this.month, this.year);
        }

        public void ReturnDayOfWeek()
        {
            DateTime date = new DateTime(this.year, this.month, this.day);
            string days = date.DayOfWeek.ToString();
            Console.Write("Thu trong tuan cua ngay da nhap la: ");
            switch (days)
            {
                case "Monday":
                    Console.WriteLine("Thu Hai");
                    break;
                case "Tuesday":
                    Console.WriteLine("Thu Ba");
                    break;
                case "Wednesday":
                    Console.WriteLine("Thu Tu");
                    break;
                case "Thursday":
                    Console.WriteLine("Thu Nam");
                    break;
                case "Friday":
                    Console.WriteLine("Thu Sau");
                    break;
                case "Saturday":
                    Console.WriteLine("Thu Bay");
                    break;
                case "Sunday":
                    Console.WriteLine("Chu Nhat");
                    break;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date();
            date.Input();
            date.Output();

            date.ReturnDayOfWeek();
        }
    }
}
