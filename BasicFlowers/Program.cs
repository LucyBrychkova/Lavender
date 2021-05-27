using System;

namespace BasicFlowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your string:");
            var inputString = Console.ReadLine();
            TDDCalc class1 = new TDDCalc();
            Console.WriteLine(class1.StringCalculator(inputString));
        }

        
    }
}
