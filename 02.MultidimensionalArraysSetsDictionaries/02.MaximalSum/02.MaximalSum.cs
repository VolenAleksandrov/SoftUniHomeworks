using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hightAndWidth = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int hight = hightAndWidth[0];
            int width = hightAndWidth[1];
            int[,] matrix = new int[hight, width];
            int sum = Int32.MinValue;
            int yOfMaxSum = 0;
            int xOfMaxSum = 0;
            int y = 0;
            int x = 0;

            for (int k = 0; k < hight; k++)
            {
                int[] enryArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int i = 0; i < width; i++)
                {
                    matrix[k, i] = enryArr[i];
                }
            }

            for (int i = 0; i < hight - 2; i++)
            {
                for (int j = 0; j < width - 2; j++)
                {
                    int sum1 = matrix[i, j] +
                          matrix[i + 1, j] +
                          matrix[i + 2, j] +
                          matrix[i + 1, j + 1] +
                          matrix[i + 2, j + 2] +
                          matrix[i + 1, j + 2] +
                          matrix[i, j + 1] +
                          matrix[i, j + 2] +
                          matrix[i + 2, j + 1];
                    if (sum < sum1)
                    {
                        sum = sum1;
                        yOfMaxSum = i;
                        xOfMaxSum = j;
                        y = yOfMaxSum + 3;
                        x = xOfMaxSum + 3;
                    }
                  
                }
            }
            Console.WriteLine();
            Console.WriteLine("Sum = " + sum);
            for (int i = yOfMaxSum; i < y; i++)
            {
                for (int j = xOfMaxSum; j < x; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
