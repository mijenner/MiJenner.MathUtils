using System;
using MiJenner; 

namespace UsageExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.Write((a = 345.67) + " converts to ");
            Console.Write(MathUtils.RoundToSignificantDigits(a, 3));
            Console.WriteLine(" with 3 significant figures");
            Console.WriteLine("and");
            Console.Write(a + " truncates to ");
            Console.Write(MathUtils.TruncateToSignificantDigits(a, 3));
            Console.WriteLine(" with 3 significant figures");

            Console.WriteLine("---------------");

            Console.Write((a = 345.67) + " converts to ");
            Console.Write(MathUtils.RoundToSignificantDigits(a, 7));
            Console.WriteLine(" with 7 significant figures");
            Console.WriteLine("and");
            Console.Write(a + " truncates to ");
            Console.Write(MathUtils.TruncateToSignificantDigits(a, 7));
            Console.WriteLine(" with 7 significant figures");
        }
    }
}