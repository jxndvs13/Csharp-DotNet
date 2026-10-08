using System;
using System.Threading;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    partial class Student
    {
        public void DisplayStudent()
        {
            Console.WriteLine("Student ID: " + StudentId);
            Console.WriteLine("Student Name: " + StudentName);
            Console.WriteLine("Major: " + Major);
        }
        public async Task GetStudentStatusAsync()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Retrieving student status...");
                Task.Delay(2000).Wait();
                Console.WriteLine("Student information retrieved successfully.");
            });
        }
        public async Task<int> GetCompletedCreditsAsync ()
        {
            await Task.Delay(1000);
            return 15;
        }
    }
}