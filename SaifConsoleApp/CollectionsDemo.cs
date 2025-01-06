using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaifConsoleApp
{
    internal class CollectionsDemo
    {
        static void Main()
        {
           // int[] rollnumber = new int[100];

            ArrayList IndiaPopulation = new ArrayList();
            //arrayList.Capacity = 10;

            IndiaPopulation.Add(1000);//Pune
            IndiaPopulation.Add(20000);//Patna
            IndiaPopulation.Add(30000);//Indore
            IndiaPopulation.Add(40000);//Delhi
            IndiaPopulation.Add(50000);//Kolkata
            //arrayList.Add(6);
            //arrayList.Add(7);
            //arrayList.Add(8);
            //arrayList.Add(9);
            //arrayList.Add(11);
            //arrayList.Add(12);
            //arrayList.Add(13);
            //arrayList.Add(13);
            //arrayList.Add(13);
            //arrayList.Add(13);
            //arrayList.Add(13);
            //arrayList.Add(13);

            //arrayList.Add(13);
            //arrayList.Add(13);
            //arrayList.Add(13);
            //arrayList.Add(13);
            //arrayList.Add(13);



            //Console.WriteLine("Added array items");
            //foreach (int i in arrayList)
            //{

            //    Console.WriteLine(i);
            //}
            //arrayList.Remove(1);

            //arrayList.RemoveAt(1);
            //Console.WriteLine("After removal the array list is as below");
            //foreach (int i in arrayList)
            //{

            //    Console.WriteLine(i);
            //}
            
            //Console.WriteLine($"Capcity ={arrayList.Capacity} and count={arrayList.Count}" );
            //arrayList.Clear();
            //Console.WriteLine($"count={arrayList.Count}");
            
            ArrayList singaporePopulation = new ArrayList();
            singaporePopulation.Add(30000);
            singaporePopulation.Add(40000);
            singaporePopulation.Add(60000);//x,y,z,

            //
            ArrayList MergedPopulationList=new ArrayList();
            MergedPopulationList.AddRange(IndiaPopulation);
            MergedPopulationList.AddRange(singaporePopulation);

            var flag=MergedPopulationList.Contains(10);
            Console.ReadLine();

        }
    }
}
