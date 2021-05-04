using System;
using System.Linq;

namespace MaxNumberGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 15, 69, 36 };
            double[] doubleArray = { 26.7, 49.86, 98.6 };
            string[] stringArray = { "25.6", "89.5", "93.5" };

            Program.MaxxNumbCheck<int>(intArray);
            Program.MaxxNumbCheck<double>(doubleArray);
            Program.MaxxNumbCheck<string>(stringArray);
            
        }
        public static void MaxxNumbCheck<T>(T[] Array)
        {
            var output = Array.Max();
            Console.WriteLine(output);
            Console.WriteLine("************");
        }
    }
}
