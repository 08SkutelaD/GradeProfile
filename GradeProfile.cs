using System;
using System.Collections.Generic;

namespace GradeSystem
{
    public class GradeProfile
    {
        private string studentID;
        private List<Grade> listOfGrades = new List<Grade>{};
        private string yearOfStudy;

        public string StudentID
        {
            get { return studentID; }
        }

        public GradeProfile(string studentID, string yearOfStudy)
        {
            this.studentID = studentID;
            this.yearOfStudy = yearOfStudy;
        }

        public void AddGrade(Grade newGrade)
        {
            listOfGrades.Add(newGrade);
        }

        private int CalculateAverageGrade()
        {
            if(listOfGrades.Count == 0)
            {
                return 0;
            }
            else
            {
                decimal gradeTotal = 0;
                decimal weightTotal = 0;
                foreach(Grade grade in listOfGrades)
                {
                    decimal weightedGrade = grade.Mark * grade.Weight;
                    gradeTotal += weightedGrade;
                    weightTotal += grade.Weight;
                }
                int total = (int)Math.Round((gradeTotal / weightTotal));
        
                return total;
            }
        }

        public void DisplayGradeProfile()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("ID: " + studentID);
            Console.WriteLine("Year of Study: " + yearOfStudy);
            int avgGrade = CalculateAverageGrade();
            Console.WriteLine("Average Grade: " + avgGrade + "%");
            Console.WriteLine("-------------------");
            if(listOfGrades.Count == 0)
            {
                Console.WriteLine("No grade entries recorded.");
            }
            else
            {
                Console.WriteLine();
                foreach(Grade grade in listOfGrades)
                {
                    grade.DisplayGradeDetails();
                    Console.WriteLine();
                }
            }
            
        }
    }
}