using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace _02.LastDigitOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetLastDigitAsWord(512));
            Console.WriteLine(GetLastDigitAsWord(1024));
            Console.WriteLine(GetLastDigitAsWord(12309));
        }

        static string GetLastDigitAsWord(int number)
        {
            string strNumber = number.ToString();
            char[] charNumber = strNumber.ToCharArray();
            int lastDigitASC = charNumber.Last();
            char lastDigit = (char)lastDigitASC;
            string result = "";
            switch (lastDigit)
            {
                case '1' :
                    result = "one";
                    break;
                case '2':
                    result = "two";
                    break;
                case '3':
                    result = "three";
                    break;
                case '4':
                    result = "four";
                    break;
                case '5':
                    result = "five";
                    break;
                case '6':
                    result = "six";
                    break;
                case '7':
                    result = "seven";
                    break;
                case '8':
                    result = "eight";
                    break;
                case '9':
                    result = "nine";
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
