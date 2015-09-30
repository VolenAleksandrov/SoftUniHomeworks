using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double reversed = GetReversed(123.45);
            Console.WriteLine(reversed);
        }

        static double GetReversed(double numToReverse)
        {
            string num = numToReverse.ToString();
            char[] numm = num.ToCharArray();
            Array.Reverse(numm);
            num = new string(numm);
            double result = Convert.ToDouble(num);
            return result;
        }
        
    }
}
