using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersInt = Console.ReadLine().Split().Select(int.Parse).ToArray();
            double[] numbersDouble = Console.ReadLine().Split().Select(double.Parse).ToArray();
            decimal[] numbersDecimal = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            Console.WriteLine("Int: ");
            Console.WriteLine("Minimum: {0} ", MinimumInt(numbersInt));
            Console.WriteLine("Maximum: {0} ", MaximumInt(numbersInt));
            Console.WriteLine("Average: {0} ", AverageInt(numbersInt));
            Console.WriteLine("Sum: {0} ", SumInt(numbersInt));
            Console.WriteLine("Product: {0} ", ProductInt(numbersInt));

            Console.WriteLine();

            Console.WriteLine("Double: ");
            Console.WriteLine("Minimum: {0} ", MinimumDouble(numbersDouble));
            Console.WriteLine("Maximum: {0} ", MaximumDouble(numbersDouble));
            Console.WriteLine("Average: {0} ", AverageDouble(numbersDouble));
            Console.WriteLine("Sum: {0} ", SumDouble(numbersDouble));
            Console.WriteLine("Product: {0} ", ProductDouble(numbersDouble));

            Console.WriteLine();

            Console.WriteLine("Decimal: ");
            Console.WriteLine("Minimum: {0} ", MinimumDec(numbersDecimal));
            Console.WriteLine("Maximum: {0} ", MaximumDec(numbersDecimal));
            Console.WriteLine("Average: {0} ", AverageDec(numbersDecimal));
            Console.WriteLine("Sum: {0} ", SumDec(numbersDecimal));
            Console.WriteLine("Product: {0} ", ProductDec(numbersDecimal));

        }
        private static int MinimumInt(int[] numbersInt)
        {
            int minimum = int.MaxValue;
            for (int i = 0; i < numbersInt.Length; i++)
            {
                if (minimum > numbersInt[i])
                {
                    minimum = numbersInt[i];
                }
            }
            return minimum;
        }
        private static int MaximumInt(int[] numbersInt)
        {
            int maximum = int.MinValue;
            for (int i = 0; i < numbersInt.Length; i++)
            {
                if (maximum < numbersInt[i])
                {
                    maximum = numbersInt[i];
                }
            }
            return maximum;
        }
        private static double AverageInt(int[] numbersInt)
        {
            double sum = 0.00;
            for (int i = 0; i < numbersInt.Length; i++)
            {
                sum += numbersInt[i];
            }
            return sum / numbersInt.Length;
        }
        private static int SumInt(int[] numbersInt)
        {
            int sum = 0;
            for (int i = 0; i < numbersInt.Length; i++)
            {
                sum += numbersInt[i];
            }
            return sum;
        }
        private static int ProductInt(int[] numbersInt)
        {
            int product = 1;
            for (int i = 0; i < numbersInt.Length; i++)
            {
                product *= numbersInt[i];
            }
            return product;
        }

        private static double MinimumDouble(double[] numbersDouble)
        {
            double minimum = double.MaxValue;
            for (int i = 0; i < numbersDouble.Length; i++)
            {
                if (minimum > numbersDouble[i])
                {
                    minimum = numbersDouble[i];
                }
            }
            return minimum;
        }
        private static double MaximumDouble(double[] numbersDouble)
        {
            double maximum = double.MinValue;
            for (int i = 0; i < numbersDouble.Length; i++)
            {
                if (maximum < numbersDouble[i])
                {
                    maximum = numbersDouble[i];
                }
            }
            return maximum;
        }
        private static double AverageDouble(double[] numbersDouble)
        {
            double sum = 0.00;
            for (int i = 0; i < numbersDouble.Length; i++)
            {
                sum += numbersDouble[i];
            }
            return sum / numbersDouble.Length;
        }
        private static double SumDouble(double[] numbersDouble)
        {
            double sum = 0;
            for (int i = 0; i < numbersDouble.Length; i++)
            {
                sum += numbersDouble[i];
            }
            return sum;
        }
        private static double ProductDouble(double[] numbersDouble)
        {
            double product = 1.00;
            for (int i = 0; i < numbersDouble.Length; i++)
            {
                product *= numbersDouble[i];
            }
            return product;
        }

        private static decimal MinimumDec(decimal[] numbersDecimal)
        {
            decimal minimum = decimal.MaxValue;
            for (int i = 0; i < numbersDecimal.Length; i++)
            {
                if (minimum > numbersDecimal[i])
                {
                    minimum = numbersDecimal[i];
                }
            }
            return minimum;
        }
        private static decimal MaximumDec(decimal[] numbersDecimal)
        {
            decimal maximum = decimal.MinValue;
            for (int i = 0; i < numbersDecimal.Length; i++)
            {
                if (maximum < numbersDecimal[i])
                {
                    maximum = numbersDecimal[i];
                }
            }
            return maximum;
        }
        private static decimal AverageDec(decimal[] numbersDecimal)
        {
            decimal sum = 0.00M;
            for (int i = 0; i < numbersDecimal.Length; i++)
            {
                sum += numbersDecimal[i];
            }
            return sum / numbersDecimal.Length;
        }
        private static decimal SumDec(decimal[] numbersDecimal)
        {
            decimal sum = 0.00M;
            for (int i = 0; i < numbersDecimal.Length; i++)
            {
                sum += numbersDecimal[i];
            }
            return sum;
        }
        private static decimal ProductDec(decimal[] numbersDecimal)
        {
            decimal product = 1.00M;
            for (int i = 0; i < numbersDecimal.Length; i++)
            {
                product *= numbersDecimal[i];
            }
            return product;
        }
    }
}
