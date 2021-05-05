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

            GenericMax<int> genericMaxInt = new GenericMax<int>(intArray);
            genericMaxInt.PrintmaxValue();
            GenericMax<double> genericMaxDouble = new GenericMax<double>(doubleArray);
            genericMaxDouble.PrintmaxValue();
            GenericMax<string> genericMaxString = new GenericMax<string>(stringArray);
            genericMaxString.PrintmaxValue();
            Console.ReadKey();
        }
       
    }
}
