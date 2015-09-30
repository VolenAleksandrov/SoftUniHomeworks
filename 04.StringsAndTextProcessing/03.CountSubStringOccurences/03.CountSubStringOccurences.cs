using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _03.CountSubStringOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine().ToLower();
            string inputString = Console.ReadLine().ToLower();
            int count = 0;
            int index = 0;

            while ((index = inputText.IndexOf(inputString, index))>=0)
            {
                index++;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
