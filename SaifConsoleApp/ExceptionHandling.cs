using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaifConsoleApp
{
    internal class ExceptionHandling
    {
        //static void Main()
        //{
        //    try
        //    {
        //        Sum();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine( ex.StackTrace);

        //    }

        //    Console.WriteLine("even exception comes code will reach here too");


        //    Console.ReadLine();

        //}

        static void Divide()
        {
            try
            {
                Console.WriteLine("Enter number");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter another  number");
                int y = Convert.ToInt32(Console.ReadLine());
                //open--the channle
                //if (y==0)
                //{
                //    throw new MyException("It is wrong to divide by zero");
                //}
                int z = x / y;


                Console.WriteLine(z);
            }

            //catch(MyException ex) {

            //    Console.WriteLine(ex.Message);
            //}
            catch (NullReferenceException ex)
            {
                throw;
                //Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                throw;
                //Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                throw;
                //Console.WriteLine(ex.Message);

            }
            
            finally
            {
                //close the connection
                Console.WriteLine("This block always runs//it should have resource free activity");


            } 
            
        }

        static void Sum()
        {
            try
            {
                //Console.WriteLine("Enter number");
                //int x = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Enter another  number");
                //int y = Convert.ToInt32(Console.ReadLine());
                Divide();
                //int z = x + y;
                //Console.WriteLine(z);
            }
            catch (Exception ex)
            {
                throw;//recommended
             //   throw ex;//you will loose the orginal exception stack trace 
            }
            
        }
    }

    class MyException:Exception {

        public MyException(string mesg):base(mesg)
        {
                
        }

    }
}
