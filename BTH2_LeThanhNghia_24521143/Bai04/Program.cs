using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction resultFraction = new Fraction();
            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction();
            Console.WriteLine("Enter the first fraction:");
            f1.Input();
            Console.WriteLine("Enter the second fraction:");
            f2.Input();

            Console.WriteLine("Add: ");
            resultFraction = f1 + f2;
            resultFraction.Output();

            Console.WriteLine("Subtract: ");
            resultFraction = f1 - f2;
            resultFraction.Output();

            Console.WriteLine("Multiple: ");
            resultFraction = f1 * f2;
            resultFraction.Output();

            Console.WriteLine("Devide: ");
            resultFraction = f1 / f2;
            resultFraction.Output();


            // Find the biggest fraction in the array
            FractionArray arrFraction = new FractionArray();
            arrFraction.Input();
            //arrFraction.RandomArray(5);
            arrFraction.Output();

            Fraction biggestFraction = arrFraction.FindTheBiggestFraction();
            Console.Write("The biggest fraction is: ");
            biggestFraction.Output();

            // Sort the fractions in the array (ascending - selection)
            arrFraction.Sort();
            arrFraction.Output();
        }
    }
}
