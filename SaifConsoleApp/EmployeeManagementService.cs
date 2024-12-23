using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaifConsoleApp
{
    class ClientCode
    {

        static void Main()
        { 
        
            EmployeeManagementService obj=new EmployeeManagementService();

            //obj creates on stack--this is just a varaible which is pointing to below object address
            //object--new EmployeeManagementService()--on heap

            //object.Methodname();
           // (new EmployeeManagementService()).Add();
            //(new EmployeeManagementService()).Get(2);
            obj.Add();
            obj.Get(1);

            Console.ReadLine();
        }
    
    }
    internal class EmployeeManagementService
    {

        public void Add()
        {
            Console.WriteLine( "Hello");

        }

        public void Get(int eid)
        {
            Console.WriteLine("Hello world");

        }

    }
}
}
