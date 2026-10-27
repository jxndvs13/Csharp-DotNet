using Microsoft.Extensions.DependencyInjection;

namespace DIWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddSingleton<IStudentRepository, StudentRepository>();
            services.AddSingleton<StudentClient>();

            var serviceProvider = services.BuildServiceProvider();
            
            var client = serviceProvider.GetRequiredService<StudentClient>();
<<<<<<< HEAD

            var stu1 = new Student
            {
                Id = 1,
                Name = "Alice",
                Major = "Computer Science"
            };
            client.AddStudent(stu1);
            var stu2 = new Student
            {
                Id = 2,
                Name = "Bob",
                Major = "Electrical Engineering"
            };
            client.AddStudent(stu2);
=======
            var stu1 = new Student { Id = 1, Name = "Alice", Major = "Computer Science" };
            client.AddStudent(stu1);
            var stu2 = new Student { Id = 2, Name = "Bob", Major = "Electrical Engineering" };
            client.AddStudent(stu2);

            Console.WriteLine("All Students:");
            foreach (var stu in client.GetAllStudents())
            {
                Console.WriteLine($"ID: {stu.Id}, Name: {stu.Name}, Major: {stu.Major}");
            }

            Console.WriteLine();
            Console.WriteLine("Get Student by ID 1:");
            var fStu = client.GetStudentById(1);
            if (fStu != null) { Console.WriteLine($"Found: {fStu.Name} - {fStu.Major}"); }
            else { Console.WriteLine("Student not found."); }
>>>>>>> 83ffcd425b7970da93cbbd999747df5704236da1
        }
    }
}