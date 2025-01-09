using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaifConsoleApp
{
    internal class ListDemo
    {
        static void Main()
        {

            //Student student1 = new Student();
            //student1.RollNumber = 1001;
            //student1.Name = "Ramesh";
            //student1.Age = 30;


            //Student student2 = new Student();
            //student2.RollNumber = 1002;
            //student2.Name = "Mahesh";
            //student2.Age = 20;


            //Student student3 = new Student();
            //student3.RollNumber = 1003;
            //student3.Name = "Suresh";
            //student3.Age = 10;

            //List<Student> students = new List<Student>();
            //students.Add(student1);
            //students.Add(student2);
            //students.Add(student3);

            ////display
            //foreach (var student in students)
            //{
            //    Console.WriteLine($"Roll Number={student.RollNumber} Name={student.Name} Age={student.Age}");
            //}


            //Dictionary<string,int> populationDict= new Dictionary<string,int>();
            //populationDict.Add("India", 10000);            
            //populationDict.Add("China", 20000);
            //populationDict.Add("Singapore", 30000);

            //foreach (var item in populationDict)
            //{
            //    Console.WriteLine( $"Country={item.Key} and Population={item.Value}");
            //}
            //int z;
            //int q;
            //int x=1;
            //int y = 2;
            //Console.WriteLine($"Before passing to sum the value x={x} and y={y}");
            //Sum(ref x,ref y,out z,out q);
            //Console.WriteLine($"After passing to sum the value x={x} and y={y}");
            //Console.WriteLine($"z={z}");
            //Console.WriteLine($"q={q}");
            //Console.ReadLine();

            //(int id, string name) = GetData();
            //Console.WriteLine(id);
            //Console.WriteLine(name);

            ClassRoom cls=new ClassRoom(80);
            cls.DisplayCount();
            //cls.Count = 50;
            //ClassRoom.Count = 30;
            //Console.WriteLine( ClassRoom.Count);
            Console.WriteLine( cls.Count);
            //cls.Count = 30;
            cls.DisplayCount();
            Console.ReadLine();



        }

        public static void Sum(ref int x,ref int y,out int z,out int q)
        {
            x = 5; y=6;
            z = x + y;
            q = x - y;
            Console.WriteLine(z);
        
        }

        public static (int,string) GetData()
        {

            return (10, "Rakesh");
        
        }

    }

    class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


    }

    public class ClassRoom
    {
        //public const int Count = 70;
        public readonly int Count=30;
        public ClassRoom(int count)
        {
            Count = count;
        }

        public void DisplayCount()
        {

            Console.WriteLine(Count);
        }


        public void SetCount()
        {
           // Count = 20;
            Console.WriteLine(Count);
        }




    }
}
