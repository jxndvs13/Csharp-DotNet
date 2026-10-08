using System;
using System.Threading;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("================================");
            Console.WriteLine("   STUDENT INFORMATION SYSTEM");
            Console.WriteLine("================================");
            await Task.Delay(500);
            Student student = new Student(101, "John Smith", "Computer Science");
            student.DisplayStudent();
            var getStatus = student.GetStudentStatusAsync();
            await getStatus;
            var completedCredits = await student.GetCompletedCreditsAsync();
            Console.WriteLine("Completed Credits: " + completedCredits);
            await Task.Delay(500);
            Console.WriteLine("================================");
        }
    }
}