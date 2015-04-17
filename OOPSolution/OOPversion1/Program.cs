using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPversion1.Models;

namespace OOPversion1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initialize Program");
            
            // *** Call Reference Class *** //
            // Note: If you pass your Class or DataType as a function Parameter
            // it is being passed as a Reference Type
            #region Reference Class

            string myStr = "Hello World";            
            Console.WriteLine(myStr); //This will print Hello World

            PassingRefParameter.ChangeValue(myStr);
            Console.WriteLine(myStr); //This will print Hello World

            PassingRefParameter.RefChangeValue(ref myStr);
            Console.WriteLine(myStr);  //This will print Changed


            int myInt = 25;
            Console.WriteLine(myInt); //This will print 25

            PassingRefParameter.ChangeIntValue(myInt);
            Console.WriteLine(myInt); //This will print 25

            PassingRefParameter.RefChangeIntValue(ref myInt);
            Console.WriteLine(myInt); //This will print 30

            #endregion

            Console.WriteLine("\n\n");
            Console.WriteLine("**********************************");
            Console.WriteLine("\n\n");

            // *** Call SampleClassA Class *** //
            #region Partial Access Modifier
            // *** Partial Access Modifier *** //
            // Partial access modifier merges class in compile time if they have the same Namespace
            // For this example we have
            // SampleClassA.cs and AccessModifier > PartialModifier > SampleClassA.cs with same Namespace OOPversion1
            Console.WriteLine("Initialize Partial Class");
            var partialClass = new SampleClassA();
            Console.WriteLine(partialClass.publicPartialInt); //You will notice that I can access both member in one instance

            #endregion

            Console.WriteLine("\n\n");
            Console.WriteLine("**********************************");
            Console.WriteLine("\n\n");


            // *** Inheritance *** //
            #region Demonstrate Inhiritance

            // Using Person class with the same fields as a Base Class of Student and Teacher
            var student = new Student()
            {
                FirstName = "Jez Reel",
                LastName = "Maghuyop",
                CompletedCourse = "B.S I.T"
            };

            student.Display();

            var teacher = new Teacher()
            {
                FirstName = "Anna Liza",
                LastName = "Ogayon",
                Department = "Information Technology",
                Subject = "Oracle 4",
                OfficeHourse = "4pm - 5pm"
            };

            teacher.Display();


            //You can create your Base class from your Sub class
            Person person1 = new Student();
            Person person2 = new Teacher();

            //But you can't create a Sub class from the Base Class
            //Student newStudent = new Person(); //You'll get an error


            #endregion


            Console.WriteLine("\n\n");
            Console.WriteLine("**********************************");
            Console.WriteLine("\n\n");




        }

    }
}
