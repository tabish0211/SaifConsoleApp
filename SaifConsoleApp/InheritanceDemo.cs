using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaifConsoleApp
{
    internal class InheritanceDemo
    {
        //class Caller
        //{

        //    static void Main()
        //    {
        //        //BMW car=new BMW();
        //        //car.Name = "GT6500";
        //        //car.CarSound();
        //        //car.EngineDetails();
        //        //car.Price = 200;

        //        BMWR bmwR = new BMWR(1,2,"Hello");
        //        BMW bmw = new BMW();

        //        bmwR.CarSound();//Boom
        //        bmw.CarSound();//Wooh

        //        bmw.Discount();

        //        //A base class reference can point to the derived class object

        //        Car car = new BMW();
        //        car.CarSound();
        //        car.Discount();
                

        //        //bmw.CarSound();//car
        //        //bmw.EngineDetails();//BMW
        //        //bmw.SpecifTORseries();//BMWRSeries
               

        //        Console.ReadLine();
        //    }
        //}

      abstract  class Car { 
        
            public string Name { get; set; }
            public string Color { get; set; }

            public Car()
            {
                Console.WriteLine("Constructor from Car Class");
            }

            public Car(int x)
            {
                Console.WriteLine("Constructor from Parametrized Car Class");
            }
            public abstract void CarSound();


            public virtual int Discount()
            {
                return 10;
            }
            ~Car()
            {
                Console.WriteLine("This is destructor from Car class");
                Console.ReadLine();
            }

        }

        class BMW : Car {

            public int Price { get; set; }

            public BMW()
            {
                Console.WriteLine("Constructor from  BMW Class");
            }

            public override  void CarSound()
            {
                Console.WriteLine("BoooM");


            }
            public BMW(int x,string y):base(x)
            {
                Console.WriteLine("Constructor from  Parametrized BMW Class");
            }

            public override int Discount()
            {
                return 5 + base.Discount();
            
               
            }

            public void EngineDetails()
            {

                Console.WriteLine("BMW Engine details");
            }

            ~BMW()
            {


                Console.WriteLine("Destructor from BMW");
            }

        }

        class BMWR : BMW {

            public BMWR()
            {
                Console.WriteLine("Constructor from BMWR Class");
            }

            public override void CarSound()
            {
                Console.WriteLine("Woooh");


            }
            public BMWR(int x, int y,string z):base(x,z)
            {
                Console.WriteLine("Constructor from Parametrized BMWR Class");
            }
            public void SpecifTORseries()
            {

                Console.WriteLine("Very specific to R series");

            }

            ~BMWR()
            {
                Console.ReadLine();
                Console.WriteLine("This is destructor, It is used for resource clean up");

            }
        
        }
    }
}
