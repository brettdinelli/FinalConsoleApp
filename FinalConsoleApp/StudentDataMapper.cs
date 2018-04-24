using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FinalConsoleApp
{
    public class StudentDataMapper : IDataMapper<Student>
    {
        private string path;
        public StudentDataMapper()
        {
            path = AppDomain.CurrentDomain.BaseDirectory + "Students.txt";
        }

        private List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            // read from the Students.txt file (using the System.IO)
            if(File.Exists(path))
            {
                // file exists, read it
                var sr = new StreamReader(path);
                string line;
                
                // read each line in Students.txt and populate a new student object
                // with values from lines in the file
                while( (line = sr.ReadLine()) != null )
                {
                    var elems = line.Split(','); // create an array from the csv
                    var student = new Student
                    {
                        ID = Int16.Parse(elems[0]),
                        FirstName = elems[1],
                        LastName = elems[2],
                        Address = elems[3],
                        City = elems[4],
                        Province = elems[5],
                        PostalCode = elems[6],
                        Phone = elems[7],
                        Email = elems[8],
                        EnrollDate = DateTime.Parse(elems[9]),
                        Major = elems[10]
                    };
                    // add each new student (one for each line in Students.txt)
                    students.Add(student);

                } // end while
            } // end if 


            return students;
        } // end GetStudents

        public List<Student> Find(string LastName)
        {
            // first, get all the students
            var searchStudents = GetStudents();

            // find students containing the searched lastname using LINQ
            // LINQ - Language Integrated Query
            // note: we will need to convert IEnumerable back to a list 

            return searchStudents.Where(s => s.LastName.Contains(LastName)).ToList();

        }

        public List<Student> Select()
        {
            return GetStudents();
        }
    }
}
