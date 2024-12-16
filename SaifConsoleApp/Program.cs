using System.Diagnostics;
using System.Net.Cache;

namespace SaifConsoleApp
{
    internal class Program
    {

        //CLR--common lanaguage runtime---JVM---Program.Main()
        //entry point method---any subroutine written inside class it is called
        
        
        static void Main()
        {

            //Single dimensional array
            //MultiDimensional array
            //Jagged array

            //int m1, m2, m3, m4;
            //aaray is collection similar data types
            //int--1,2,3,4,5
            //char--'a'
            //Console.WriteLine("Enter the size of an array");
            //int size = Convert.ToInt32(Console.ReadLine());

            //int[] arr=new int[size];//{0,0,0,0,0....}[0]---[9]
            //Console.WriteLine(arr[2]);//thrid element
            //arr[2] = arr[2] + 10;

            //for (int i = 0; i < arr.Length; i++)
            //{

            //    Console.WriteLine(arr[i]);
            //}

            //Console.WriteLine("tell number of subjects for which you would like to enter marks");
            //int count = Convert.ToInt32(Console.ReadLine());

            //int[] marks=new int[count];

            //for (int i = 0; i < marks.Length; i++)
            //{

            //    Console.WriteLine($"enter the marks for subject {i+1}:");
            //    marks[i]= Convert.ToInt32(Console.ReadLine());


            //}

            //for (int i = 0; i < marks.Length; i++)
            //{

            //    Console.WriteLine($"Marks for subject {i + 1} ={marks[i]} ");

            //}
            //assignment
            //percentage---max marks--100
            //average
            //int[,] tabularSubjects=new int[2,3];

            //for (int i = 0; i < tabularSubjects.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter marks for class {i+1}");
            //    for (int j = 0; j < tabularSubjects.GetLength(1); j++)
            //    {
            //        Console.WriteLine( $"subject {j+1}");
            //        tabularSubjects[i, j] = Convert.ToInt32(Console.ReadLine());

            //    }

            //}

            //for (int i = 0; i < tabularSubjects.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Entered marks for class {i + 1}");
            //    for (int j = 0; j < tabularSubjects.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"subject {j + 1} ={tabularSubjects[i, j]}");

            //    }

            //}

            //for (int i = 0; i < tabularSubjects.GetLength(0); i++)
            //{

            //    for (int j = 0; j < tabularSubjects.GetLength(1); j++)
            //    {
            //        Console.Write($"{tabularSubjects[i, j]}\t");

            //    }
            //    Console.WriteLine();
            //}

            //assignment average
            //highest scorer
            //Console.WriteLine("Enter the  1st dimension of the jagged array");
            //int row=Convert.ToInt32(Console.ReadLine());

            //int[][] arrJagged = new int[row][];
            //for (int i = 0; i < arrJagged.Length; i++)
            //{
            //    Console.WriteLine("Enter the  column dimension of the jagged array");
            //    int col = Convert.ToInt32(Console.ReadLine());
            //    arrJagged[i] = new int[col];
            //}
           
            ////assignmnet expression

            ////output

            //for (int i = 0; i < arrJagged.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrJagged[i].GetLength(0); j++)
            //    {
            //        Console.WriteLine(arrJagged[i][j]);
            //    }
            //}

            int[] arrVal = { 6, 2, 1, 9, 0 };
            //Console.WriteLine("Before sorting");
            Console.WriteLine("Before Reevrsing");
            for (int i = 0; i < arrVal.Length; i++)
            {
                Console.WriteLine(arrVal[i]);
            }

           // Console.WriteLine( "after sorting");
            //Array.Sort(arrVal);//ascending
            Console.WriteLine("after reversing");
            Array.Reverse(arrVal);
            for (int i = 0; i < arrVal.Length; i++)
            {
                Console.WriteLine(arrVal[i]);
            }

            //descending 
            Console.ReadLine();

        }
    }
}
