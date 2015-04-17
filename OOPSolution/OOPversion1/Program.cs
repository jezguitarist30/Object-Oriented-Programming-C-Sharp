using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

       
        }

    }
}
