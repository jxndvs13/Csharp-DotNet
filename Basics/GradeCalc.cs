using System;

namespace Basics
{
    class GradeCalc
    {
         public static void Test()
        {
            Console.WriteLine("Input Number of Students");
            int len = int.Parse(Console.ReadLine());
            double[] studentMarks = new double[len];
            Console.WriteLine("Input Grades for all {0} Students", len);
            for (int i = 0; i < len; i++)
            {
                studentMarks[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Students: " + len);
            Console.WriteLine("Total: " + studentMarks.Sum());
            Console.WriteLine("Highest: " + studentMarks.Max());
            Console.WriteLine("Lowest: " + studentMarks.Min());
            Console.WriteLine("All Grades: ");
            for (int i = 0; i < len; i++) { Console.WriteLine(studentMarks[i]); }
        }
    }
}