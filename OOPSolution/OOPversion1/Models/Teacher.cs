using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPversion1.Models
{
    class Teacher: Person
    {
        #region Extended Fields

        public string Subject { get; set; }
        public string OfficeHourse { get; set; }
        public string Department { get; set; }

        #endregion

        #region Logic or Methods or Functions

        public void Display()
        {
            Console.WriteLine("Teacher: " + FirstName + " " + LastName);
            Console.WriteLine("Subject of Proficiency: " + Subject);
            Console.WriteLine("Office Hours: " + OfficeHourse);
            Console.WriteLine("Department: " + Department);
        }

        #endregion
    }                                                                                                 
}
