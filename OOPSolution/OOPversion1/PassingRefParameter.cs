using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPversion1
{
    //Need to make this a Public Static class to be able to call from outside the class
    public static class PassingRefParameter
    {

        //Non reference type method
        public static void ChangeValue(string x)
        {
            x = "Changed";
        }


        //Reference Type Method
        public static void RefChangeValue(ref string x)
        {
            x = "Changed";
        }



        //Non reference type method
        public static void ChangeIntValue(int x)
        {
            x = 12;
        }


        //Reference Type Method
        public static void RefChangeIntValue(ref int x)
        {
            x = 30;
        }
    }
}
