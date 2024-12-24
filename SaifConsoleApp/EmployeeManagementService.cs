using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaifConsoleApp
{
    class ClientCode
    {

        //static void Main()
        //{ 
        
        //    EmployeeManagementService obj=new EmployeeManagementService();

        //    // //obj creates on stack--this is just a varaible which is pointing to below object address
        //    // //object--new EmployeeManagementService()--on heap

        //    // //object.Methodname();
        //    //// (new EmployeeManagementService()).Add();
        //    // //(new EmployeeManagementService()).Get(2);
        //    // obj.Add();
        //    // obj.Get(1);

        //    //obj.SetId(1);
        //    //int id=obj.GetId();
        //   // obj.Id = 1;//set
        //   // int id = obj.Id;//get
        //   // Console.WriteLine( obj.Id);//get



        //    Console.ReadLine();
        //}
    
    }
    internal class EmployeeManagementService
    {
        //private int _id;
        private string _name;

        //public void SetId(int id)
        //{
        //    _id = id;
        //}

        //public int GetId()
        //{
        //    return _id;
        //}

        //property---C#2.0-----C# 4.0---C#13
        //public int Id
        //{
        //    get { return _id; }
        //    set { _id = value; }
        //}

        //property--C# 4.0--
        public int Id { get; set; }
        public string Name { get; set; }

        public char Gender { get; set; }
        //public void Add()
        //{
        //    Console.WriteLine( "Hello");

        //}

        //public void Get(int eid)
        //{
        //    Console.WriteLine("Hello world");

        //}



    }
}

