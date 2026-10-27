using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassWork3
{
    public class Employee
    {
        private int empId;
        private string empName;
        public int empAge;
        private int empSalary;
        public string empQualification;
        public string empDesignation;
        public Employee(int empId, string empName, int empAge, int empSalary, string empQualification, string empDesignation)
        {
            this.empId = empId;
            this.empName = empName;
            this.empAge = empAge;
            this.empSalary = empSalary;
            this.empQualification = empQualification;
            this.empDesignation = empDesignation;
        }
        public int EmpId
        {
            get { return empId; }
        }
        public string EmpName
        {
            get { return empName; }
        }
        public int EmpSalary
        {
            get { return empSalary; }
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine(empId + " - " + empName + "; Age: " + empAge);
            Console.WriteLine(empQualification + "\tSalary: " + empSalary);
            Console.WriteLine(empDesignation);
            Console.WriteLine();
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            // initialize employee objects
            List<Employee> empList = new List<Employee> {
            new Employee(937, "John Doe", 30, 50000, "BS", "Programmer"),
            new Employee(685, "Jane Smith", 28, 60000, "MS", "Senior Programmer"),
            new Employee(815, "Mike Johnson", 55, 70000, "PhD", "Project Lead"),
            new Employee(438, "Emily Davis", 32, 55000, "BS", "Programmer"),
            new Employee(137, "David Wilson", 29, 65000, "MS", "Senior Programmer"),
            new Employee(828, "Sarah Brown", 57, 72000, "MBA", "Manager"),
            new Employee(614, "Chris Lee", 24, 48000, "BS", "Programmer"),
            new Employee(872, "Olivia Taylor", 43, 58000, "MS", "Senior Programmer"),
            new Employee(1218, "Daniel Anderson", 20, 20000, "HS", "Systems Intern"),
            new Employee(915, "Sophia Martinez", 30, 52000, "BS", "Programmer")
            };

            // display all employees
            Console.WriteLine("\nAll Employees:\n");
            List<Employee> ascList = empList.OrderBy(emp => emp.EmpId).ToList();
            foreach (Employee emp in ascList)
            {
                emp.DisplayEmployeeDetails();
            }
            Console.WriteLine("-------------------------------------\n");

            // Qualification
            List<String> highDegrees = new List<String> { "MS", "PhD", "MBA" };
            List<Employee> qualList = empList.Where(emp => highDegrees.Contains(emp.empQualification)).ToList();
            Console.WriteLine("\nEmployees with Masters or Higher:\n");
            foreach (Employee emp in qualList)
            {
                emp.DisplayEmployeeDetails();
            }
            Console.WriteLine("-------------------------------------\n");

            // Total Salary
            int totalSalary = empList.Sum(emp => emp.EmpSalary);
            Console.WriteLine("Total Salary of all Employees: " + totalSalary);
            Console.WriteLine("\n-------------------------------------\n");

            // Aproaching Retirement
            List<Employee> retireList = empList.Where(emp => emp.empAge >= 55).ToList();
            Console.WriteLine("Employees Approaching Retirement:\n");
            foreach (Employee emp in retireList)
            {
                emp.DisplayEmployeeDetails();
            }
        }
    }
}