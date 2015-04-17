using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPversion1.Models
{
    class Person
    {
        #region Data or Fields

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// False: Female
        /// </summary>
        public bool Gender { get; set; }
        #endregion

        #region Extended Fields


        #endregion

        #region Logic or Methods or Functions

        public void Walk()
        {
            Console.WriteLine(FirstName + " is walking.");
        }

        public void Talk()
        {
            Console.WriteLine(FirstName + " is talking.");
        }

        public void Eat()
        {
            Console.WriteLine(FirstName + " is eating.");
        }

        #endregion

        #region Destructor

        ~Person()
        {
            Console.WriteLine("Destructor is called!");
        }

        #endregion

    }
}
