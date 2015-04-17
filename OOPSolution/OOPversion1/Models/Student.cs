using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPversion1.Models
{
    class Student: Person
    {
        #region Extended Fields

        public DateTime EnrolDate { get; set; }
        public string CompletedCourse { get; set; }

        #endregion


        #region Logic or Methods or Functions

        public void Display()
        {
            Console.WriteLine("Student: " + FirstName + " " + LastName);
            Console.WriteLine("Completed Course:" + CompletedCourse);
        }

        #endregion

    }
}
