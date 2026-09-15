using System;

namespace Basics
{
    class DigitCount
    {
        internal static void Test()
        {
            Console.WriteLine("Calculate the summ of the individual digits of a number:");
            Console.WriteLine("-----------------------------------------------------------");
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int temp = 0;
                if (int.TryParse(input[i].ToString(), out temp))
                {
                    sum += temp;
                }
            }
            Console.WriteLine("The sum of the digits of the number {0} is: {1}", input, sum);
        }
    }
}