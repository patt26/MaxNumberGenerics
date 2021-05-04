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
        }
    }
}
