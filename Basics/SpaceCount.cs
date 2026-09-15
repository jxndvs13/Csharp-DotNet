using System;
using System.Runtime.InteropServices;

namespace Basics
{
    class SpaceCount
    {
        internal static void Test()
        {
            Console.WriteLine("Count number of spaces in a string:");
            Console.WriteLine("--------------------------------------");
            Console.Write("Input a string: ");
            string input = Console.ReadLine();
            char[] array = new char[input.Length];
            input.CopyTo(0,array,0,input.Length-1);
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == ' ')
                {
                    count += 1;
                }
            }
            Console.WriteLine("{0} contains {1} spaces.", input, count);
        }
    }
}