using System;
using System.Threading;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    partial class Student
    {
        int StudentId;
        String StudentName;
        String Major;
        public Student(int studentId, String studentName, String major)
        {
            this.StudentId = studentId;
            this.StudentName = studentName;
            this.Major = major;
        }
    }
}