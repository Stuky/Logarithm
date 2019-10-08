using System;

namespace Logarithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the input of Log10?");
            var log10Value = Log10(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(log10Value);
            Console.ReadLine();
        }

        static double ln10 => 2.3025850929940456840179914546844;

        static double Log10(double x)
        {
            if (x <= 0)
            {
                return double.NaN;
            }

            return Ln(x) / ln10;
        }

        static double Ln(double x)
        {
            double previousSummary = 0.0;
            double xMinusOneDividedXPlusOne = (x - 1) / (x + 1);
            double MultiplyXMinusOneDividedXPlusOne = xMinusOneDividedXPlusOne * xMinusOneDividedXPlusOne;
            double denominator = 1.0;
            double fraction = xMinusOneDividedXPlusOne;
            double term = fraction;
            double summary = term;

            while (summary != previousSummary)
            {
                previousSummary = summary;
                denominator += 2.0;
                fraction *= MultiplyXMinusOneDividedXPlusOne;
                summary += fraction / denominator;
            }

            return 2.0 * summary;
        }
    }
}