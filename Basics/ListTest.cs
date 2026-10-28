using System;
using System.Collections.Generic;

namespace Basics
{
    class ListTest
    {
        public static void Test()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            int i = 4;
            var temp = numbers[i];
            numbers[i] = numbers[i - 1];
            numbers[i - 1] = temp;
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}