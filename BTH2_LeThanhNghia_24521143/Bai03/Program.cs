using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            matrix.Input();
            matrix.Output();
            matrix.FindElement();
            matrix.PrintPrimeNum();
            matrix.FindRowWithMostPrime();
        }
    }
}
