using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new []{',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            string inputText = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                inputText = inputText.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
            }
            Console.WriteLine(inputText);
        }
    }
}
