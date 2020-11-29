using System;
using myCalc;

namespace CSharp_DLL_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 + 2 = {0}", Calculator.Add(3, 2));
            Console.WriteLine("3 - 2 = {0}", Calculator.Sub(3, 2));
            Console.ReadLine();

        }
    }
}
