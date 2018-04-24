using System;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleApp
{
    public class Instructor: Person
    {
        // Instructor inherits all the properties of the person

        // Instructor-specific properties
        public DateTime HireDate { get; set; } // property

        private string _rank;  // private field (encapsulation)

        public string Rank
        {
            get
            {
                int years = YearsOfWork(this.HireDate);
                if(years >= 25)
                {
                    _rank = Ranking.DistinguishedProfessor.ToString();
                }
                else if(years >= 20)
                {
                    _rank = Ranking.FullProfessor.ToString();
                }
                else if(years >= 15)
                {
                    _rank = Ranking.AssociateProfessor.ToString();
                }
                else if(years >= 10)
                {
                    _rank = Ranking.AssistantProfessor.ToString();
                }
                else
                {
                    _rank = Ranking.Instructor.ToString();
                }

                return _rank;
            } // end get

            set
            {
                _rank = value;
            }
        }

        // ranking enum
        private enum Ranking : byte
        {
            Instructor = 1, 
            AssistantProfessor = 2, 
            AssociateProfessor = 3, 
            FullProfessor = 4, 
            DistinguishedProfessor = 5
        }

        private static int YearsOfWork(DateTime HireDate)
        {
            DateTime now = DateTime.Today;
            int yrsExp = now.Year - HireDate.Year;
            if(HireDate.AddYears(yrsExp) > now)
            {
                yrsExp--;
            }

            return yrsExp;
        }

        public string InstructorName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

    } // end Instructor class
} // end namespace
