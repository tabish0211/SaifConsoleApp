using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaifConsoleApp
{
    internal class Customer
    {
        private string _name;
        private string email;
        
        //deafult--there is no parameter

        //Overloading Constructor
        //especial method whose name is same as that of class name 
        //to initialized class memeber at the time of object creation
        public Customer() {
            Console.WriteLine("This is a default constructor");
        }

        //parametrized constructor
        public Customer(string name)
        {
            _name = name;
          //  Console.WriteLine($"Parametrized constructor {_name}");
        }

        public Customer(string name,string email): this(name)
        {
            //_name = name;//DRY---Do not repeat yourself
            this.email = email;
            Console.WriteLine("parametrized constructro called");
        }

        static Customer()
        {
            Console.WriteLine("If you want to do some sort of configuration even before actual object creation use static constructor");

        }

        //copy constructor
        public Customer CopyConstructor() {
            
            //Shallow copy
            // Customer customerCopy = new Customer(customer._name,customer.email);
            Customer customerCopy=(Customer)this.MemberwiseClone();            
            return customerCopy;

        }

        public void Display()
        { 
        

        
        }

    }

    class Caller
    {

        //static void Main()
        //{ 
        
        //    Customer customer = new Customer("Ramesh","ramesh@gmail.com");

        //    Customer customer1 = customer.CopyConstructor();
           
        //    Console.ReadLine();
        //}
    }
}
