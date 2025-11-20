using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    internal class FractionArray
    {
        private int n; // The number of the elements in the array
        private Fraction[] array;

        public FractionArray(int n = 0)
        {
            this.n = n;
            this.array = new Fraction[n];
            for (int i = 0; i < this.n; i++)
            {
                this.array[i] = new Fraction();
            }
        }

        public void Input()
        {
            Console.Write("Enter the number of elements in the array: ");
            string inputValue = Console.ReadLine();
            if (!int.TryParse(inputValue, out this.n))
            {
                Console.WriteLine("Invalid data!");
                Environment.Exit(0);
            }
            if (this.n < 0)
            {
                Console.WriteLine("This value cant be smaller than 0.");
                Environment.Exit(0);
            }
            this.array = new Fraction[n];
            
            // Enter each element of the array
            for (int i = 0; i < this.n; i++)
            {
                this.array[i] = new Fraction();
                this.array[i].Input();
            }
        }

        public void Output()
        {
            Console.WriteLine("The fractions: ");
            for (int i = 0; i < this.n; i++)
            {
                Console.Write("{0}. ", i + 1);
                this.array[i].Output();
            }
        }

        public Fraction FindTheBiggestFraction()
        {
            Fraction tempFraction = new Fraction();
            tempFraction = this.array[0];
            for (int i = 1; i < this.n; i++)
            {
                if ((this.array[i] - tempFraction).GetValue() > 0)
                {
                    tempFraction = this.array[i];
                }
            }
            return tempFraction;
        }

        public void Swap(ref Fraction p1, ref Fraction p2)
        {
            Fraction temp = new Fraction();
            temp = p1;
            p1 = p2;
            p2 = temp;
        }

        public void Sort() // Selection sort
        {
            int minIndex;
            for (int i = 0; i < this.n - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < this.n; j++)
                {
                    if ((this.array[j] - this.array[minIndex]).GetValue() < 0) // If find any fraction smaller than the current fraction (max)
                    {
                        minIndex = j;
                    }
                }
                Swap(ref this.array[i], ref this.array[minIndex]);
            }
        }
        
        static Random rand = new Random();
        public void RandomArray(int n = 0)
        {
            this.n = n;
            this.array = new Fraction[n];
            for (int i = 0; i < this.n; i++)
            {
                this.array[i] = new Fraction();
                this.array[i].RandomFraction(rand);
            }
        }
    }
}
