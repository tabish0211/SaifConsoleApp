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
            //who is eldest amongts three brother
            Console.WriteLine("enter the age of A");
            int ageA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the age of B");
            int ageB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the age of C");
            int ageC = Convert.ToInt32(Console.ReadLine());
           
            if (ageA > ageB) {
                if (ageA>ageC)
                {
                    Console.WriteLine( "A is eldest one");
                }
                else
                {
                    Console.WriteLine("C is eldest one");
                }

            

            }

            else
            {
                if (ageB > ageC)
                {
                    Console.WriteLine("B is eldest one");
                }
                else
                {
                    Console.WriteLine("C is eldest one");
                }

            }
            Console.ReadLine();

        }
    }
}
