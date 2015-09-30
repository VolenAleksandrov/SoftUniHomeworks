using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _06.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char>input = Console.ReadLine().ToCharArray().ToList();
            input.Sort();
            List<char> letersList = new List<char>();
            int countLetter = 0;
            for (int i = 0; i < input.Count; i++)
            {
                countLetter = input.Count(p => p == input[i]);
                if (!letersList.Contains(input[i]))
                {
                    Console.WriteLine(input[i] + ": " + countLetter + " time/s");
                }
                letersList.Add(input[i]);
            }
        }
    }
}
