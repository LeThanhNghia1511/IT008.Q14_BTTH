using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LandManager landManager = new LandManager();
            landManager.Input();
            landManager.Output();

            landManager.PrintTotalPrice();

            landManager.PrintLandsWithConditions();

            landManager.Search();
        }
    }
}
