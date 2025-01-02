using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaifConsoleApp
{
    internal class ExceptionHandling
    {
        static void Main()
        {

            Divide();
            Sum();

            Console.ReadLine();

        }

        static void Divide()
        {
            try
            {
                Console.WriteLine("Enter number");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter another  number");
                int y = Convert.ToInt32(Console.ReadLine());
                //open--the channle
                if (y==0)
                {
                    throw new MyException("It is wrong to divide by zero");
                }
                int z = x / y;


                Console.WriteLine(z);
            }

            catch(MyException ex) {

                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            
            finally
            {
                //close the connection
                Console.WriteLine("This block always runs//it should have resource free activity");


            } 
            
        }

        static void Sum()
        {
            Console.WriteLine("Enter number");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another  number");
            int y = Convert.ToInt32(Console.ReadLine());

            int z = x + y;
            Console.WriteLine(z);
        }
    }

    class MyException:Exception {

        public MyException(string mesg):base(mesg)
        {
                
        }

    }
}
