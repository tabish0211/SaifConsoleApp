using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaifConsoleApp
{
    internal class LinqDemo
    {
        static void Main()
        {
            var employees = GetData();
            //Linq 
            var lstEmployees= employees.Where(e => e.Name == "Rakesh").ToList();

            //foreach (var employee in lstEmployees)
            //{
            //    Console.WriteLine($"Id:{employee.Id} Name:{employee.Name} Gender:{employee.Gender}" +
            //        $" Salary:{employee.Salary} Age:{employee.Age}");
            //}


            //foreach (var employee in employees.Where(e => e.Name.Contains("ul")).ToList())
            //{
            //    Console.WriteLine($"Id:{employee.Id} Name:{employee.Name} Gender:{employee.Gender}" +
            //        $" Salary:{employee.Salary} Age:{employee.Age}");
            //}

            //if (employees.All(e=>e.Age<25))
            //{
            //    Console.WriteLine("All the employees are less 60 age");

            //}

            //else
            //{
            //    Console.WriteLine("Not All the employees are less 60 age");

            //}

            //if (employees.Any(e => e.Age < 25))
            //{
            //    Console.WriteLine("Any one of  the employees are less 25 age");

            //}

            //else
            //{
            //    Console.WriteLine("Not All the employees are less 60 age");

            //}
           // int count=employees.Count;
           // int totalSalary=employees.Sum(e => e.Salary);
           // int averageSal=(int)employees.Average(e => e.Salary);
           // int maxSal = employees.Max(e => e.Salary);
           //var employeMaxSal =employees.Where(e=>e.Salary==maxSal).ToList();

            //var emp=employees.ElementAt(7);
           // var emp=employees.ElementAtOrDefault(7);

            //var emp=employees.First(e=>e.Name=="Surya");
           // var emp = employees.FirstOrDefault(e => e.Name == "Surya");
         //  var emp=employees.Single(e=>e.Name=="Surya");
           // var emp = employees.SingleOrDefault(e => e.Name == "Surya");



            Console.ReadLine();

        }

        private static List<Employee> GetData()
        {
            List<Employee> employees = new List<Employee>();
            Employee employee1 = new Employee()
            {
                Id = 101,
                Name = "Rakesh",
                Gender = "Male",
                Salary = 20000,
                Age = 25
            };

            Employee employee2 = new Employee()
            {
                Id = 102,
                Name = "Mahesh",
                Gender = "Male",
                Salary = 30000,
                Age = 34
            };

            Employee employee3 = new Employee()
            {
                Id = 103,
                Name = "Abdul",
                Gender = "Male",
                Salary = 10000,
                Age = 23
            };

            Employee employee4 = new Employee()
            {
                Id = 104,
                Name = "Maya",
                Gender = "Female",
                Salary = 29000,
                Age = 37
            };
            Employee employee5 = new Employee()
            {
                Id = 105,
                Name = "Sana",
                Gender = "Female",
                Salary = 50000,
                Age = 42
            };

            Employee employee6 = new Employee()
            {
                Id = 106,
                Name = "Danish",
                Gender = "Male",
                Salary = 50000,
                Age = 45
            };

            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(employee6);

            return employees;

            
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
