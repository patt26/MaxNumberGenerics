using System;

namespace MaxNumberGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            int output = MaxNumberCheck.MaximumIntegerNumber(15, 69, 36);
            Console.WriteLine("The Maximum Integer Number is " + output);
            Console.ReadKey();

            double doubleOutput = MaxNumberCheck.MaximumDoubleNumber(26.7, 49.86, 98.67);
            Console.WriteLine("The Maximum Float Number is " + doubleOutput);
            Console.ReadKey();
        }
    }
}
