using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new[] {' ', ',', '.', '!', '?'},
                StringSplitOptions.RemoveEmptyEntries);
            List<string> result = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                char[] reversedd = input[i].ToCharArray();
                Array.Reverse(reversedd);
                string reversed = new string(reversedd);
                if (input[i] == reversed)
                {
                    result.Add(reversed);   
                }
            }
            result.Sort();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
