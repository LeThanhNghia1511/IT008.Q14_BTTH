using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bai03
{
    internal class Matrix
    {
        private int row;
        private int column;
        private int[,] matrix;

        public Matrix(int row = 0, int column = 0)
        {
            this.row = row;
            this.column = column;
        }

        public void Input()
        {
            Console.Write("Enter the row of the matrix: ");
            string inputRow = Console.ReadLine();
            Console.Write("Enter the column of the matrix: ");
            string inputColumn = Console.ReadLine();
            if (!int.TryParse(inputRow, out this.row) || !int.TryParse(inputColumn, out this.column))
            {
                Console.WriteLine("Invalid input data!");
                Environment.Exit(0);
            }

            if (this.row < 0 || this.column < 0 )
            {
                Console.WriteLine("Error! Row and Column cant be smaller than 0.");
                Environment.Exit(0);
            }

            this.matrix = new int[this.row, this.column];
            Console.WriteLine("Enter the elements");
            for (int i = 0; i < this.column; i++)
            {
                for (int j = 0; j < this.row; j++)
                {
                    this.matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //this.CreateRandomMatrix();
        }

        public void CreateRandomMatrix()
        {
            Random random = new Random();
            for (int i = 0; i < this.row; i++)
            {
                for (int j = 0; j < this.column; j++)
                {
                    this.matrix[i, j] = random.Next(1, 21); // Random tu -10 den 10
                }
            }
        }

        public void Output()
        {
            Console.WriteLine("The matrix:");
            for (int i = 0; i < this.row; i++)
            {
                for (int j = 0; j < this.column; j++)
                {
                    Console.Write("{0}\t", this.matrix[i, j]);
                }

                Console.WriteLine();
            }
        }

        // Tim kiem phan tu trong ma tran va in ra tat ca vi tri cua phan tu do
        public void FindElement()
        {
            Console.Write("Enter the element you want to find in the matrix: ");
            string inputElement = Console.ReadLine();
            int element;
            if (!int.TryParse(inputElement, out element))
            {
                Console.WriteLine("Invalid input data!");
            }
            bool isFound = false;
            for (int i = 0; i < this.row; i++)
            {
                for (int j = 0; j < this.column; j++)
                {
                    if (this.matrix[i, j] == element)
                    {
                        isFound = true;
                        // In ra toa do vi tri
                        Console.WriteLine("({0}, {1})", i, j);
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine("Can't find the element!");
            }
        }

        bool IsPime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return n > 1;
        }

        public void PrintPrimeNum()
        {
            Console.WriteLine("The prime numbers in the matrix:");
            for (int i = 0; i < this.row; i++)
            {
                for (int j = 0; j < this.column; j++)
                {
                    if (IsPime(this.matrix[i, j]))
                    {
                        Console.Write("{0}\t", this.matrix[i, j]);
                    }
                }
            }
            Console.WriteLine();
        }

        int CountPrimeInRow(int row)
        {
            int count = 0;
            for (int i = 0; i < this.row; i++)
            {
                if (IsPime(this.matrix[row, i]))
                {
                    count++;
                }
            }
            return count;
        }

        public void FindRowWithMostPrime()
        {
            int numOfPrimeNum = CountPrimeInRow(0);
            int temp, row = 0;
            for (int i = 1; i < this.row; i++)
            {
                temp = CountPrimeInRow(i);
                if (numOfPrimeNum < temp)
                {
                    numOfPrimeNum = temp;
                    row = i;
                }
;            }
            Console.WriteLine("The row with most prime is {0} with {1} primes", row, numOfPrimeNum);
        }
           
    }
}
