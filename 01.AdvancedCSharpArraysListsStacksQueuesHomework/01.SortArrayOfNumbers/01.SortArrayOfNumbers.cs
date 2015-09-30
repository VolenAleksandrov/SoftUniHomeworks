using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SortArrayOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inp = Console.ReadLine().Split();
            int[] nums = Array.ConvertAll(inp, int.Parse);
            Array.Sort(nums);
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
