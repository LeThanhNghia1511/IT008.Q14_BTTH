using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    internal class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator = 1, int denomiator = 1)
        {
            this.numerator = numerator;
            this.denominator = denomiator;
            if (denominator == 0)
            {
                Console.WriteLine("Cant create a 0 denominator fraction, it's gonna be 1");
                this.denominator = 1;
            }
        }

        public void Input()
        {
            Console.Write("Enter the numerator: ");
            string inputNumerator = Console.ReadLine();
            Console.Write("Enter the denominator: ");
            string inputDenominator = Console.ReadLine();
            if (!int.TryParse(inputNumerator, out this.numerator) || !int.TryParse(inputDenominator, out this.denominator))
            {
                Console.WriteLine("Invalid data!");
            }
            while (this.denominator == 0)
            {
                Console.WriteLine("Error! Denominator cant be 0. Try again");
                Console.Write("Enter the denominator: ");
                this.denominator = int.Parse(Console.ReadLine());
            }
            this.Normalized();
        }

        int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        void Normalized()
        {
            int gcd = GCD(this.numerator, this.denominator);
            this.numerator /= gcd;
            this.denominator /= gcd;

            if (this.denominator < 0)
            {
                this.numerator = -this.numerator;
                this.denominator = -this.denominator;
            }
        }

        public void Output()
        {
            Console.WriteLine("{0}/{1}\t Value: " + this.GetValue().ToString("F3"), this.numerator, this.denominator);
        }

        public static Fraction operator +(Fraction p1, Fraction p2)
        {
            Fraction fraction = new Fraction();
            fraction.numerator = p1.numerator * p2.denominator + p2.numerator * p1.denominator;
            fraction.denominator = p1.denominator * p2.denominator;
            fraction.Normalized();
            return fraction;
        }

        public static Fraction operator -(Fraction p1, Fraction p2)
        {
            Fraction fraction = new Fraction();
            fraction.numerator = p1.numerator * p2.denominator - p2.numerator * p1.denominator;
            fraction.denominator = p1.denominator * p2.denominator;
            fraction.Normalized();
            return fraction;
        }

        public static Fraction operator *(Fraction p1, Fraction p2)
        {
            Fraction fraction = new Fraction();
            fraction.numerator = p1.numerator * p2.numerator;
            fraction.denominator = p1.denominator * p2.denominator;
            fraction.Normalized();
            return fraction;
        }

        public static Fraction operator /(Fraction p1, Fraction p2)
        {
            if (p2.numerator == 0)
            {
                Console.WriteLine("Cant be devided by 0");
                Environment.Exit(0);
            }
            Fraction fraction = new Fraction();
            fraction.numerator = p1.numerator * p2.denominator;
            fraction.denominator = p1.denominator * p2.numerator;
            fraction.Normalized();
            return fraction;
        }

        public float GetValue()
        {
            return (float)this.numerator / this.denominator;
        }

        public void RandomFraction(Random rand)
        {
            this.numerator = rand.Next(-200, 201);
            this.denominator = rand.Next(-200, 201);
        }
    }
}
