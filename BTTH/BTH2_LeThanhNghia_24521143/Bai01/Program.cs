using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date(16, 12, 2025);
            date.Input2();
            date.Output();
            date.DisplayCalendar();
        }
    }
}
