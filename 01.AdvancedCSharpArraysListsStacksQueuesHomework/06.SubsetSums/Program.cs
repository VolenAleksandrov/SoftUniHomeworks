using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SubSetSums
{
    static void Main()
    {
        int sumNumber = int.Parse(Console.ReadLine());
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] sequence = input.Distinct().ToArray();

        double combinations = Math.Pow(2, sequence.Length);

        List<int> sumsList = new List<int>();
        bool match = false;

        for (int i = 1; i < combinations; i++)
        {
            int sum = 0;
            CheckCombination(i, sequence, ref sumsList);
            sum = sumsList.Sum();

            if (sum == sumNumber)
            {
                Console.WriteLine("{0} = {1}", string.Join(" + ", sumsList.Select(x => x.ToString()).ToArray()), sumsList.Sum());
                match = true;
            }

            sumsList = new List<int>();
        }

        if (match == false)
        {
            Console.WriteLine("No matching subsets.");
        }
    }

    private static void CheckCombination(int bitMask, int[] intArray, ref List<int> sumsList)
    {
        int sumOfCombination = 0;
        for (int i = 0; i < intArray.Length; i++)
        {
            if (bitMask % 2 != 0)
            {
                sumOfCombination += intArray[i];
                sumsList.Add(intArray[i]);
            }
            bitMask >>= 1;
        }
    }
}