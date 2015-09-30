using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SequencesOfEqualSrtings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int count = 0;

            for (int i = 0; i < input.Length; i = i + count)
            {
                count = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        count++;
                    }
                }
                for (int k = 0; k < count; k++)
                {
                    Console.Write(input[i] + " ");
                }
                Console.WriteLine();


            }
        }
    }
}
