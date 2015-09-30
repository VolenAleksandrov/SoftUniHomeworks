using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            string[,] matrix = new string[rows,cols];
            List<string> result = new List<string>();
            string a = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    string num = Console.ReadLine();
                    matrix[i, j] = num;
                }
            }

            string command = Console.ReadLine();
            
            while (command != "END")
            {
                string[] coordinates = command.Split();
                if (coordinates[0] != "swap" )
                {
                    Console.WriteLine("Invalid input");
                    goto blabla;
                }
                int x1 = int.Parse(coordinates[1]);
                int y1 = int.Parse(coordinates[2]);
                int x2 = int.Parse(coordinates[3]);
                int y2 = int.Parse(coordinates[4]);

                if (x1 > rows && x2 > rows && y1 > cols && y2 > cols)
                {
                    Console.WriteLine("Invalid input");
                    goto blabla;
                }
                string strToChange = matrix[x1, y1];
                matrix[x1,y1] = matrix[x2, y2];
                matrix[x2, y2] = strToChange;
                
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(matrix[i,j] + " ");
                        ;
                    }
                    Console.WriteLine();
                }
                blabla:
                command = Console.ReadLine();   
            }
        }
    }
}
