using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string result = "";
            int br = 0;
            int sequenceLength = 1, maxSequenceLength = 1;
            int longestSequenceEndIndex = 0;

            int temporaryIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                result = "" + input[i];
                temporaryIndex = i;

                for (int j = i + 1; j < input.Length; j++)
                {
                    i = j - 1;
                    if (input[i] < input[j])
                    {
                        result += " " + input[j];
                        sequenceLength++;

                    }
                    else
                    {
                        sequenceLength = 1;
                        break;
                    }

                    if (sequenceLength > maxSequenceLength)
                    {
                        maxSequenceLength = sequenceLength;
                        longestSequenceEndIndex = j;
                    }

                    br++;
                }

                i = temporaryIndex;
                i += br;
                br = 0;
                Console.WriteLine(result);

            }
            Console.Write("Longest: ");
            for (int i = longestSequenceEndIndex - maxSequenceLength + 1; i <= longestSequenceEndIndex; i++)
            {
                Console.Write(input[i] + " ");
            }
        }
    }
}