using System;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleApp
{
    public class Student: Person
    {
        // the : is the inheritance symbol
        // a Student is inheriting all the properties from Person

        // Student-specific properties
        public DateTime EnrollDate { get; set; }
        public string Major { get; set; }

        // read only property
        // manually creating with a get only
        public string StudentName
        {
            get
            {
                //return FirstName + " " + LastName;
                return LastName + ", " + FirstName;
            }
        }
    } // end Student class
} // end namespace
