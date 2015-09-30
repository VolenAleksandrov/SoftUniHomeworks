using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CategorizeNumbersAndFindMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inp = Console.ReadLine().Split();
            double[] nums = Array.ConvertAll(inp, double.Parse);
            List<int> roundNums = new List<int>();
            List<double> floatNums = new List<double>();
            for (int i = 0; i < nums.Length; i++)
            {
                double numC = Math.Truncate(nums[i]);
                if (nums[i] - numC == 0)
                {
                    roundNums.Add((int)nums[i]);
                }
                else
                {
                    floatNums.Add(nums[i]);
                }
            }
            double minFloat = floatNums.Min();
            double maxFloat = floatNums.Max();
            double sumFloat = floatNums.Sum();
            double avgFloat = sumFloat / floatNums.Count;

            int minRound = roundNums.Min();
            int maxRound = roundNums.Max();
            int sumRound = roundNums.Sum();
            int avgRound = sumRound / roundNums.Count;

            Console.Write("[");
            Console.Write(string.Join(", ", floatNums));
            Console.Write("]");
            Console.WriteLine(" -> min: {0}, max: {1}, sum: {2}, avg: {3:F2}", minFloat, maxFloat, sumFloat, avgFloat);
            Console.WriteLine();
            Console.Write("[");
            Console.Write(string.Join(", ", roundNums));
            Console.Write("]");
            Console.WriteLine(" -> min: {0}, max: {1}, sum: {2}, avg: {3:F2}", minRound, maxRound, sumRound, avgRound);
        }
    }
}
