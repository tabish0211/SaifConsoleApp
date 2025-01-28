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

            //var sortedEmployeeonSal= employees.OrderBy(x=>x.Salary).ToList();
            // var sortedDescEmployeeonSal = employees.OrderByDescending(x => x.Salary).ToList();
            // var sortedEmployeeonSalThenBy = employees.OrderBy(x => x.Salary).ThenBy(x=>x.Age).ToList();
            // var sortedDescEmployeeonSalThenBy = employees.OrderByDescending(x => x.Salary).ThenByDescending(x=>x.Age).ToList();
            // foreach (var employee in sortedDescEmployeeonSalThenBy)
            // {
            //     Console.WriteLine($"Id:{employee.Id} Name:{employee.Name} Gender:{employee.Gender}" +
            //         $" Salary:{employee.Salary} Age:{employee.Age}");
            // }


            //var employeesDept = GetDataEmployeeDept();
            //var groupedEmployees=employeesDept.GroupBy(x => x.DeptName).ToList();

            //foreach (var item in groupedEmployees)
            //{
            //    Console.WriteLine($"Dept={item.Key} and employee count={item.Count()}");
            //    //foreach (var employee in item)
            //    //{
            //    //    Console.WriteLine($"Id:{employee.Id} Name:{employee.Name} Gender:{employee.Gender}" +
            //    //     $" Salary:{employee.Salary} Age:{employee.Age}");
            //    //}

            //}

            var employeeswithids = GetDataEmployeesWithDeprtId();
            var selectedData= employeeswithids.Select(e => new { Name = e.Name, Age = e.Age });
            foreach (var item in selectedData)
            {
                Console.WriteLine(item.Age);
            }
            
            var departments = GetDepartments();
            //var innerJoin=employeeswithids.Join(departments,
            //    emp => emp.DeptId,
            //    department => department.Id,
            //   (emp, department) = new { Id = emp.Id });

            var innerJoin = from employee in employeeswithids // outer sequence
                            join Department in departments //inner sequence 
                            on employee.DeptId equals Department.Id // key selector 
                            select new
                            { 
                                EmployeeName = employee.Name,
                                DepartmentName = Department.Name

                            };
            foreach (var item in innerJoin)
            {
                Console.WriteLine($"Employee={item.EmployeeName} and Department={item.DepartmentName}");
            }
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
        private static List<EmployeeDept> GetDataEmployeeDept()
        {
            List<EmployeeDept> employees = new List<EmployeeDept>();
            EmployeeDept employee1 = new EmployeeDept()
            {
                Id = 101,
                Name = "Rakesh",
                Gender = "Male",
                Salary = 20000,
                Age = 25,
                DeptName="Electronics"
            };

            EmployeeDept employee2 = new EmployeeDept()
            {
                Id = 102,
                Name = "Mahesh",
                Gender = "Male",
                Salary = 30000,
                Age = 34,
                DeptName = "Electronics"
            };

            EmployeeDept employee3 = new EmployeeDept()
            {
                Id = 103,
                Name = "Abdul",
                Gender = "Male",
                Salary = 10000,
                Age = 23,
                DeptName = "CSC"
            };

            EmployeeDept employee4 = new EmployeeDept()
            {
                Id = 104,
                Name = "Maya",
                Gender = "Female",
                Salary = 29000,
                Age = 37,
                DeptName = "CSC"
            };
            EmployeeDept employee5 = new EmployeeDept()
            {
                Id = 105,
                Name = "Sana",
                Gender = "Female",
                Salary = 50000,
                Age = 42,
                DeptName = "Mechanical"

            };

            EmployeeDept employee6 = new EmployeeDept()
            {
                Id = 106,
                Name = "Danish",
                Gender = "Male",
                Salary = 50000,
                Age = 45,
                DeptName = "Mechanical"
            };

            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(employee6);

            return employees;


        }

        private static List<EmployeeDepartment> GetDataEmployeesWithDeprtId()
        {
            List<EmployeeDepartment> employees = new List<EmployeeDepartment>();
            EmployeeDepartment employee1 = new EmployeeDepartment()
            {
                Id = 101,
                Name = "Rakesh",
                Gender = "Male",
                Salary = 20000,
                Age = 25,
                DeptId = 2001
            };

            EmployeeDepartment employee2 = new EmployeeDepartment()
            {
                Id = 102,
                Name = "Mahesh",
                Gender = "Male",
                Salary = 30000,
                Age = 34,
                DeptId = 2001
            };

            EmployeeDepartment employee3 = new EmployeeDepartment()
            {
                Id = 103,
                Name = "Abdul",
                Gender = "Male",
                Salary = 10000,
                Age = 23,
                DeptId = 2002
            };

            EmployeeDepartment employee4 = new EmployeeDepartment()
            {
                Id = 104,
                Name = "Maya",
                Gender = "Female",
                Salary = 29000,
                Age = 37,
                DeptId = 2001
            };
            EmployeeDepartment employee5 = new EmployeeDepartment()
            {
                Id = 105,
                Name = "Sana",
                Gender = "Female",
                Salary = 50000,
                Age = 42,
                DeptId = 2003

            };

            EmployeeDepartment employee6 = new EmployeeDepartment()
            {
                Id = 106,
                Name = "Danish",
                Gender = "Male",
                Salary = 50000,
                Age = 45,
                DeptId = 2003
            };

            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(employee6);

            return employees;


        }
        private static List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();
            Department Dept1 = new Department()
            {
                Id = 2001,
                Name = "Electronics"

            };

            Department Dept2 = new Department()
            {
                Id = 2002,
                Name = "CSC"

            };


            Department Dept3 = new Department()
            {
                Id = 2003,
                Name = "Mechanical"

            };
            departments.Add(Dept1);
            departments.Add(Dept2);
            departments.Add(Dept3);

            return departments;


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

    class EmployeeDept
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string DeptName { get; set; }
    }

    class EmployeeDepartment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int DeptId { get; set; }
    }

    class Department
    {
        public int Id { get; set; }        
        public string Name { get; set; }

    }
}
