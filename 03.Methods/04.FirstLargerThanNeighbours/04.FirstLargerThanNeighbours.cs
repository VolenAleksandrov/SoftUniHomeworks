using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequenceOne = {1, 3, 4, 5, 1, 0, 5};
            int[] sequenceTwo = {1, 2, 3, 4, 5, 6, 6};
            int[] sequenceThree = {1, 1, 1};

            Console.WriteLine(IsLargerThanNeighbours(sequenceOne));
            Console.WriteLine(IsLargerThanNeighbours(sequenceTwo));
            Console.WriteLine(IsLargerThanNeighbours(sequenceThree));
        }
        private static int IsLargerThanNeighbours(int[] numbers)
        {
            bool isBigger = false;
            int i = 0;
            for (i = 0; i < numbers.Length - 2; i++)
            {
                if ((numbers[i] > numbers[i + 1]) && (numbers[i] > numbers[i + 2]))
                {
                    isBigger = true;
                    break;
                }
            }
            if (isBigger == true)
            {
                return i;
            }
            else return -1;
        }

    }
}
