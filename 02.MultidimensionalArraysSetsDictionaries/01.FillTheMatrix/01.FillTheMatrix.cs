using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FillTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            int otherCells = n+1;
            for (int i = 0; i < n; i++)
            {
                int firstCell = i + 1;
                otherCells = firstCell + n;
                for (int j = 0; j < n; j++)
                {
                    if (j == 0)
                    {
                        matrix[i, j] = firstCell;
                    }
                    else
                    {
                        matrix[i, j] = otherCells;
                        otherCells += n;
                    }

                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            int k = (n*2) -1;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int firstCell = i + 1;
                otherCells = firstCell;
                for (int j = 0; j < n; j++)
                {
                    if (j == 0)
                    {
                        matrix[i, j] = firstCell;
                    }
                    else if (j % 2 == 0)
                    {
                        otherCells += b;
                        matrix[i, j] = otherCells;
                    }
                    else if (j % 2 != 0)
                    {
                        otherCells += k;
                        matrix[i, j] = otherCells;
                    }
                }
                k -= 2;
                b += 2;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
