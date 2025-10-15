using System;

namespace Bai06
{
    internal class Program
    {
        // Ham tao ma tran voi n dong va m cot co cac gia tri ngau nhien
        static int[,] CreateRandomMatrix()
        {
            int row, column;
            Console.Write("Nhap so dong cua ma tran: ");
            row = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot cua ma tran: ");
            column = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, column];
            Random random = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = random.Next(-20, 21); // Tao cac gia tri ngau nhien tu -20 den 20
                }
            }

            return matrix;
        }

        // Ham in ra ma tran
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++) // GetLenght(0) = row
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // GetLength(1) = column
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Ham tim gia tri lon nhat trong ma tran
        static int FindMaxValue(int[,] matrix)
        {
            int maxValue = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++) // GetLenght(0) = row
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // GetLength(1) = column
                {
                    if (matrix[i, j] > maxValue)
                        maxValue = matrix[i, j];
                }
            }
            return maxValue;
        }

        // Ham tim gia tri nho nhat trong ma tran
        static int FindMinValue(int[,] matrix)
        {
            int minValue = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++) // GetLenght(0) = row
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // GetLength(1) = column
                {
                    if (matrix[i, j] < minValue)
                        minValue = matrix[i, j];
                }
            }
            return minValue;
        }

        // Ham tim dong co tong cac gia tri cua cac so tren dong do la lon nhat
        static int FindBiggestSumRow(int[,] matrix)
        {
            int tempSum = 0, sum = 0, index = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
                tempSum += matrix[i, 0]; // Tim tong cua dong dau tien

            for (int i = 1; i < matrix.GetLength(0); i++) // GetLenght(0) = row
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // GetLength(1) = column
                {
                   sum += matrix[i, j];
                }
                if (sum > tempSum)
                {
                    tempSum = sum;
                    index = i;
                }
                sum = 0; // Reset sum de tinh tong cua hang tiep theo
            }
            return index + 1; // Dong bang chi so cong them 1
        }

        // Ham kiem tra so nguyen to
        static bool IsPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return n > 1;
        }

        // Ham tinh tong cac gia tri khong phai so nguyen to
        static long CalSumOfNotPrimeNum(int[,] matrix)
        {
            long sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++) // GetLenght(0) = row
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // GetLength(1) = column
                {
                    if (!IsPrime(matrix[i, j])) // Neu khong phai so nguyen to
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }

        // Ham xoa dong thu k trong ma tran (tao ma tran khac va copy du lieu qua)
        static void DeleteK_IndexRow(ref int[,] matrix, int k)
        {
            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);

            int[,] newMatrix = new int[row - 1, column]; // Ma tran moi co it hon 1 dong
            int newRow = 0;
            for (int i = 0; i < matrix.GetLength(0); i++) // GetLenght(0) = row
            {
                if (i == k - 1) continue;
                for (int j = 0; j < matrix.GetLength(1); j++) // GetLength(1) = column
                {
                    newMatrix[newRow, j] = matrix[i, j];
                }
                newRow++;
            }
            matrix = newMatrix;
        }

        // Ham tim chi so cot cua so lon nhat trong ma tran
        static int FindBiggestNumColumnIndex(int[,] matrix)
        {
            int maxValue = matrix[0, 0];
            int index = 0;
            for (int i = 0; i < matrix.GetLength(0); i++) // GetLenght(0) = row
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // GetLength(1) = column
                {
                    if (matrix[i, j] > maxValue)
                    {
                        maxValue = matrix[i, j];
                        index = j;
                    }
                }
            }
            return index;
        }

        // Ham xoa cot thu k
        static void DeleteK_IndexColumn(ref int[,] matrix, int k)
        {
            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);

            int[,] newMatrix = new int[row, column - 1]; // Ma tran moi co it hon 1 cot
            int newColumn = 0;
            for (int i = 0; i < matrix.GetLength(0); i++) // GetLenght(0) = row
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // GetLength(1) = column
                {
                    if (j == k) continue;
                    newMatrix[i, newColumn] = matrix[i, j];
                    newColumn++;
                }
                newColumn = 0;
            }
            matrix = newMatrix;
        }

        // Ham xoa cot co so lon nhat
        static void DeleteBiggestNumColummn(ref int[,] matrix)
        {
            DeleteK_IndexColumn(ref matrix, FindBiggestNumColumnIndex(matrix));
        }

        static void Main(string[] args)
        {
            // Tao va in ra ma tran co cac gia tri ngau nhien
            int[,] myMatrix = CreateRandomMatrix();

            // Nhap gia tri k (dong can xoa)
            int k;
            Console.Write("Nhap dong k can xoa: ");
            k = int.Parse(Console.ReadLine());
            if (k < 1 || k > myMatrix.GetLength(0))
            {
                Console.WriteLine("Khong hop le!");
                Environment.Exit(0);
            }

            // a. Xuat ma tran
            PrintMatrix(myMatrix);

            // b. Tim phan tu lon nhat, nho nhat
            int max = FindMaxValue(myMatrix);
            int min = FindMinValue(myMatrix);
            Console.WriteLine("Gia tri lon nhat va nho nhat trong ma tran lan luot la {0} va {1}", max, min);

            // c. Tim dong co tong lon nhat
            int row = FindBiggestSumRow(myMatrix);
            Console.WriteLine("Dong co tong lon nhat trong ma tran la dong {0}", row);

            // d. Tinh tong cac so khong phai so nguyen to
            long sum = CalSumOfNotPrimeNum(myMatrix);
            Console.WriteLine("Tong cac so khong phai so nguyen to la: {0}", sum);

            // e. Xoa dong thu k trong ma tran
            DeleteK_IndexRow(ref myMatrix, k);
            Console.WriteLine("Ma tran sau khi xoa hang thu k: ");
            PrintMatrix(myMatrix);

            // f. Xoa cot chua phan tu lon nhat trong ma tran
            DeleteBiggestNumColummn(ref myMatrix);
            Console.WriteLine("Ma tran sau khi xoa cot co so lon nhat: ");
            PrintMatrix(myMatrix);
        }
    }
}
