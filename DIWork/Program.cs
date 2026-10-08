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
        }
    }
}