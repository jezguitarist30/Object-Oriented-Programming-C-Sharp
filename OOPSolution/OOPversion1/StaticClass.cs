using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPversion1
{
    class StaticClass
    {
        //If you didn't put any access modifiers it will automatically set into Private
        /// <summary>
        /// Static Method Print Name
        /// Parameter: string name
        /// </summary>
        static void PrintName(string name)
        {
            Console.WriteLine("My Name is: " + name);
        }


        //Private Non static Method
        //calling a non-public static member is  not possible from a non-static member.
        //calling a static member is only 
        void Walk()
        {
            Console.WriteLine("Call walk method");

            //*** This will cause Errors ***//

            //Calling a non-public static member is not possible outside the class.
            //StaticClass.Print("Jez Reel");

            //Calling a non-public static member is not possible from non static member.
            //this.Print("Anna Liza");

        }

        //Private Static Method        
        static void Run()
        {
            Console.WriteLine("I am Running!");


            //*** This will cause Error ***//

            //Cannont Use "this" in a static member            
            //this.PrintName("Anna Liza"); 

            //*** This will be Successfull ***//
            StaticClass.PrintName("Jez Reel"); //You can call Static Member from a Static Member
            
        }


    }


    class PublicStaticClassA
    {
        //Public Static Method
        public static void PrintName(string name)
        {
            Console.WriteLine("My Name is: " + name);
        }

        //Private non-static method
        void Walk()
        {
            Console.WriteLine("Call Public Walk.");

            //*** This will be Successfull ***//
            //You can call Public Static Member by it's class name without instantiating
            PublicStaticClassA.PrintName("Jez Reel");
            
        }
    }


    class PublicStaticClassB
    {
        public PublicStaticClassB()
        {
            PublicStaticClassA.PrintName("John"); //Call public static members by it's class name without instantiating
        }

        void SampleMethod()
        {
            PublicStaticClassA.PrintName("Michael"); //Call public static members by it's class name without instantiating
        }

        static void SampleMethod2()
        {
            PublicStaticClassA.PrintName("Ariel"); //Call public static members by it's class name without instantiating
        }
    }

}
