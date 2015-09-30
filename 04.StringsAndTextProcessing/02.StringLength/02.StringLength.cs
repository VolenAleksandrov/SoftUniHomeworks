using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 20; i++)
            {
                if (i < input.Length)
                {
                    sb.Append(input[i]);
                }
                else
                {
                    sb.Append("*");
                }
            }
            Console.WriteLine(sb);
        }
    }
}
