using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            string[,] matrix = new string[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }

            int maxCount = 0;
            string maxString = "";
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    int countX = 0;
                    int countY = 0;

                    while (row + countX < matrix.GetLength(0))
                    {
                        if (matrix[row, column] == matrix[row + countX, column])
                        {
                            countX++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (countX + 1 > maxCount)
                    {
                        maxCount = countX;
                        maxString = matrix[row, column];
                    }

                    while (column + countY < matrix.GetLength(1))
                    {
                        if (matrix[row, column] == matrix[row, column + countY])
                        {
                            countY++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (countY + 1 > maxCount)
                    {
                        maxCount = countY;
                        maxString = matrix[row, column];
                    }
                    countX = 0;

                    while (row + countX < matrix.GetLength(0) && column + countX < matrix.GetLength(1))
                    {
                        if (matrix[row, column] == matrix[row + countX, column + countX])
                        {
                            countX++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (countX + 1 > maxCount)
                    {
                        maxCount = countX;
                        maxString = matrix[row, column];
                    }
                }
            }

            Console.Write(maxString);
            for (int i = 1; i < maxCount; i++)
            {
                Console.Write(",{0}", maxString);
            }
        }
    }
}
