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
        }
    }
}