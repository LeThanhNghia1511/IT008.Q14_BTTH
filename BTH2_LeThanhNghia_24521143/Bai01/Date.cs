using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class Date
    {
        private int day, month, year;
        public Date(int day = 1, int month = 1, int year = 1)
        {
            this.day = day;
            this.month = month;
            this.year = year;
            if (!this.IsValidDate())
            {
                Console.WriteLine("Ngay khong hop le!");
                Environment.Exit(0);
            }
        }

        public void Input()
        {
            Console.Write("Nhap ngay: ");
            string inputDay = Console.ReadLine();

            Console.Write("Nhap thang: ");
            string inputMonth = Console.ReadLine();

            Console.Write("Nhap nam: ");
            string inputYear = Console.ReadLine();

            if (!int.TryParse(inputYear, out this.day) || !int.TryParse(inputMonth, out this.month) || !int.TryParse(inputYear, out this.month))
            {
                Console.WriteLine("Du lieu khong hop le!");
                return;
            }
            if (!this.IsValidDate())
            {
                Console.WriteLine("Ngay khong hop le!");
                Environment.Exit(0);
            }
        }

        public void Input2()
        {
            this.day = 1;
            Console.Write("Nhap thang: ");
            string inputMonth = Console.ReadLine();

            Console.Write("Nhap nam: ");
            string inputYear = Console.ReadLine();

            if (!int.TryParse(inputMonth, out this.month) || !int.TryParse(inputYear, out this.year))
            {
                Console.WriteLine("Du lieu khong hop le!");
                Environment.Exit(0);
            }
            if (!this.IsValidDate())
            {
                Console.WriteLine("Ngay khong hop le!");
                Environment.Exit(0);
            }
        }

        public void Output()
        {
            Console.WriteLine("Ngay da nhap: {0}/{1}/{2}", day, month, year);
        }

        public bool IsLeapYear()
        {
            if (this.year % 400 == 0 || (this.year % 4 == 0 && this.year % 100 != 0))
            {
                return true;
            }
            return false;
        }

        public int DaysInMonth()
        {
            int[] daysInMonth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (this.IsLeapYear()) // Neu la nam nhuan thi thang 2 co 29 ngay
            {
                daysInMonth[1] = 29;
            }
            return daysInMonth[this.month - 1];
        }

        public bool IsValidDate()
        {
            // Kiem tra ngay hop le
            if (this.day < 1 || this.month < 1 || this.month > 12 || this.year < 1)
            {
                return false;
            }
            else if (this.day > this.DaysInMonth())
            {
                return false;
            }
            return true;
        }

        public int GetNumOfSpace()
        {
            string dayOfWeek = new DateTime(this.year, this.month, 1).DayOfWeek.ToString();
            switch (dayOfWeek)
            {
                case "Sunday":
                    return 0;
                case "Monday":
                    return 1;
                case "Tuesday":
                    return 2;
                case "Wednesday":
                    return 3;
                case "Thursday":
                    return 4;
                case "Friday":
                    return 5;
                case "Saturday":
                    return 6;
                default:
                    return -1;
            }
        }

        public void DisplayCalendar()
        {
            Console.WriteLine("Sun\tMon\tTue\tWed\tThu\tFri\tSat");
            int numOfSpace = this.GetNumOfSpace();
            int days = this.DaysInMonth();
            int day = 1;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i == 0 && j < numOfSpace)
                    {
                        Console.Write("\t");
                    }
                    else if (day <= days)
                    {
                        Console.Write("{0}\t", day);
                        day++;
                    }
                    else
                    {
                        return;
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
