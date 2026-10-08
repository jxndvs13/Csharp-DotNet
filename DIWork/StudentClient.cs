using System.Collections.Generic;

namespace DIWork
{
    public class StudentClient
    {
        private readonly IStudentRepository _studentRepository;

        public StudentClient(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void AddStudent(Student student)
        {
            _studentRepository.AddStudent(student);
        }

        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }

        public Student GetStudentById(int id)
        {
            return _studentRepository.GetStudentById(id);
        }
    }    
}