using System;
using System.Collections.Generic;

namespace Basics
{
    public class GradeTracker
    {
        public enum Names
        {
            Billy = 84,
            Bob = 75,
            Joe = 98,
            Ben = 92,
            Harrison = 80
        }
        public static void Test()
        {
            var students = new List<Names>() {Names.Billy, Names.Bob, Names.Joe, Names.Ben, Names.Harrison};

            foreach (var stu in students)
            {
                Console.Write(stu);
                int grade = (int)stu;
                if (grade >= 97) { Console.WriteLine(" 'A+'"); }
                else if (grade >= 94 && grade <= 97) { Console.WriteLine(" 'A'"); }
                else if (grade >= 90 && grade <= 93) { Console.WriteLine(" 'A-'"); }
                else if (grade >= 87 && grade <= 90) { Console.WriteLine(" 'B+'"); }
                else if (grade >= 84 && grade <= 87) { Console.WriteLine(" 'B'"); }
                else if (grade >= 80 && grade <= 83) { Console.WriteLine(" 'B-'"); }
                else if (grade >= 77 && grade <= 80) { Console.WriteLine(" 'C+'"); }
                else if (grade >= 74 && grade <= 77) { Console.WriteLine(" 'C'"); }
                else if (grade >= 70 && grade <= 73) { Console.WriteLine(" 'C-'"); }
                else if (grade >= 67 && grade <= 70) { Console.WriteLine(" 'D+'"); }
                else if (grade >= 64 && grade <= 67) { Console.WriteLine(" 'D'"); }
                else if (grade >= 60 && grade <= 63) { Console.WriteLine(" 'D-'"); }
                else { Console.WriteLine(" 'F'"); }
            }
        }
    }
}