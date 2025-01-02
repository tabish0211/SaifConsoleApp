//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SaifConsoleApp
//{
//    internal interface  IDocumentTypeOne
//    {
//        void Write(string text);

        
//    }

//    internal interface  IDocumentTypeTwo
//    {
//        string Read();
//    }

//    //Wipro
//    internal class DocumentUserOne : IDocumentTypeOne
//    {
        
//        //Implicit
//        public void Write(string text)
//        {
//            //logfile--write--txt
//        }

//        public void Display()
//        {

//            Console.WriteLine( "Hello");
//        }
//    }

//    //Cognizant
//    internal class DocumentUserTwo : IDocumentTypeOne, IDocumentTypeTwo
//    {
      
//        public  string Read()
//        {
//            return "";
//        }

       

//        public  void Write(string text)
//        {

//        }
//    }

//    internal class Wrapper
//    {
//        public static IDocumentTypeOne CreateInstance()
//        {
//            IDocumentTypeOne userOne = new DocumentUserOne();
//            return userOne;
//        }
    
//    }

//    internal class Caller
//    {
//        static void Main() {

//            // var obj = Wrapper.CreateInstance() ;
//            ////Wrapper wrap = new Wrapper();
//            ////var obj=wrap.CreateInstance();
//            //////i = 1;
//            //obj.Write("Hello");

//            I1 obj = new A();
//            obj.M1();//I am from I1


//            I2 obj1 = new A();
//            obj.M1();//I am from I2


//        }
    
//    }

//    interface I1
//    {

//        void M1();
//    }

//    interface I2
//    {

//        void M1();
//    }

//    class A : I1, I2
//    {
//        void I1.M1()
//        {
//            Console.WriteLine("I am from I1");
//        }

//        void I2.M1()
//        {
//            Console.WriteLine("I am from I2");
//        }
//    }
//}
