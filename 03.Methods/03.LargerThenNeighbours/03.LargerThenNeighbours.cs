using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LargerThenNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 3, 4, 5, 1, 0, 5};

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(numbers,i));
            }
        }

        static bool IsLargerThanNeighbours(int[] nums, int index)
        {
            bool isLarger = false;

            if (index == 0 && nums[index] > nums[index + 1])
            {
                isLarger = true;
            }
            if (index < nums.Length - 1)
            {
                if (nums[index] > nums[index + 1] &&
                    nums[index] > nums[index - 1] &&
                    index != 0 &&
                    index != nums.Length)
                {
                    isLarger = true;
                }
            }

            if (index == nums.Length - 1)
            {
                isLarger = true;
            }

            return isLarger;
        }
    }
}
