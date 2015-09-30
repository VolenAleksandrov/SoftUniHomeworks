using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SortArrayOfNumsUsingSelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inp = Console.ReadLine().Split();
            int[] nums = Array.ConvertAll(inp, int.Parse);
            int posMin, x;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                posMin = i;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[posMin])
                    {
                        
                        posMin = j;
                    }
                }
                if (posMin != i)
                {
                    x = nums[i];
                    nums[i] = nums[posMin];
                    nums[posMin] = x;
                }
            }
        }
    }
}
