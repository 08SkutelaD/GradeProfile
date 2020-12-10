using System;
using System.Collections.Generic;

namespace GradeSystem
{
    class GradeViewer
    {
        public static List<Student> listOfStudents = new List<Student>{};
        public static List<GradeProfile> listOfGradeProfiles = new List<GradeProfile>{};
        public static List<Student> listOfSearchResults = new List<Student>{};
        
        public static void Initialise()
        {
            listOfStudents.Add(new Student("P28173492", "John", "McCarthy", "24/04/97", "jmacc2413@mail.com"));
            listOfStudents.Add(new Student("P84736281", "Sarah", "Lawson", "05/09/99", "saraaa@mail.com"));
            listOfStudents.Add(new Student("P12847362", "Matt", "Butler", "14/02/95", "butlerm@mail.com"));
            listOfStudents.Add(new Student("P29281723", "Jane", "Harper", "22/04/98", "janeharper@mail.com"));
            listOfStudents.Add(new Student("P75628471", "Sam", "Clarke", "15/12/01", "samiclarke@mail.com"));

            
            listOfGradeProfiles.Add(new GradeProfile("P28173492", "1")); // John's First Year
            listOfGradeProfiles.Add(new GradeProfile("P28173492", "2")); // John's Second Year
            listOfGradeProfiles.Add(new GradeProfile("P84736281", "1")); // Sarah's First Year
            listOfGradeProfiles.Add(new GradeProfile("P12847362", "1")); // Matt's First Year
            listOfGradeProfiles.Add(new GradeProfile("P12847362", "2")); // Matt's Second Year
            listOfGradeProfiles.Add(new GradeProfile("P12847362", "3")); // Matt's Third Year
            listOfGradeProfiles.Add(new GradeProfile("P29281723", "1")); // Jane's First Year
            listOfGradeProfiles.Add(new GradeProfile("P75628471", "1")); // Sam's First Year
            
             /*
                Introductory Programming
                Mathematics for Computing

                Object Oriented Programming
                Digital Asset Development

                Advanced Programming
                Final Major Project
            */

            // John's First Year
            listOfGradeProfiles[0].AddGrade(new Grade("Introductory Programming", "010", 74, 0.5M));
            listOfGradeProfiles[0].AddGrade(new Grade("Introductory Programming", "011", 62, 0.5M));
            listOfGradeProfiles[0].AddGrade(new Grade("Mathematics for Computing", "010", 72, 0.3M));
            listOfGradeProfiles[0].AddGrade(new Grade("Mathematics for Computing", "011", 80, 0.7M));
            
            // John's Second Year
            listOfGradeProfiles[1].AddGrade(new Grade("Object Oriented Programming", "010", 91, 0.3M));
            listOfGradeProfiles[1].AddGrade(new Grade("Object Oriented Programming", "011", 61, 0.7M));
            
            // Sarah's First Year
            listOfGradeProfiles[2].AddGrade(new Grade("Introductory Programming", "010", 76, 0.5M));
            listOfGradeProfiles[2].AddGrade(new Grade("Introductory Programming", "011", 88, 0.5M));
            listOfGradeProfiles[2].AddGrade(new Grade("Mathematics for Computing", "010", 92, 0.3M));
            listOfGradeProfiles[2].AddGrade(new Grade("Mathematics for Computing", "011", 86, 0.7M));

            // Matt's First Year
            listOfGradeProfiles[3].AddGrade(new Grade("Introductory Programming", "010", 99, 0.5M));
            listOfGradeProfiles[3].AddGrade(new Grade("Introductory Programming", "011", 95, 0.5M));
            listOfGradeProfiles[3].AddGrade(new Grade("Mathematics for Computing", "010", 89, 0.3M));
            listOfGradeProfiles[3].AddGrade(new Grade("Mathematics for Computing", "011", 87, 0.7M));
            
            //Matt's Second Year
            listOfGradeProfiles[4].AddGrade(new Grade("Object Oriented Programming", "010", 73, 0.3M));
            listOfGradeProfiles[4].AddGrade(new Grade("Object Oriented Programming", "011", 92, 0.7M));
            listOfGradeProfiles[4].AddGrade(new Grade("Digital Asset Development", "010", 91, 0.6M));
            listOfGradeProfiles[4].AddGrade(new Grade("Digital Asset Development", "011", 92, 0.4M));

            //Matt's Third Year
            listOfGradeProfiles[5].AddGrade(new Grade("Advanced Programming", "010", 90, 0.5M));
            listOfGradeProfiles[5].AddGrade(new Grade("Advanced Programming", "011", 90, 0.5M));
            
            //Sam's First Year
            listOfGradeProfiles[6].AddGrade(new Grade("Introductory Programming", "010", 68, 0.5M));
            listOfGradeProfiles[6].AddGrade(new Grade("Introductory Programming", "011", 57, 0.5M));

           
        }
        
        public static void Run()
        {
            bool isRunning = true;
            while(isRunning == true)
            {
                switch(MainMenu())
                {
                    case '1': 
                        StudentSearch();
                        break;
                    case '2': 
                        AddStudent();
                        break;
                    case '3': 
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }

        static char MainMenu()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine("Student Grade System");
            Console.WriteLine("--------------------");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1) Student Search");
            Console.WriteLine("2) Add a Student");
            Console.WriteLine("3) Exit");
            Console.WriteLine("--------------------");
            char userOption = Console.ReadKey(true).KeyChar;
            return userOption;
        }

        static void StudentSearch()
        {
            Console.Clear();
            Console.CursorVisible = true;
            Console.WriteLine("Student Grade System");
            Console.WriteLine("--------------------");
            Console.WriteLine("Enter Student: ");
            Console.WriteLine("(Enter Student Surname or ID)");
            Console.SetCursorPosition(15,2);
            string studentEntered = Console.ReadLine();
            
            Console.Clear();
            listOfSearchResults.Clear();
            foreach(Student student in listOfStudents)
            {
                if(student.StudentID == studentEntered || student.LastName == studentEntered)
                {
                    listOfSearchResults.Add(student);
                }
            }
            Console.WriteLine("----------------");
            Console.WriteLine("Search Results:");
            foreach(Student student in listOfSearchResults)
            {
                int index = listOfSearchResults.IndexOf(student);
                index += 1;
                Console.WriteLine(index + ") " + student.FirstName + " " + student.LastName + " (" + student.StudentID + ")");
            }
            Console.WriteLine("Select student using the number keys.");
            Console.WriteLine("----------------");
            var userChoice = Console.ReadKey(true).KeyChar;
            int userVal = (int)Char.GetNumericValue(userChoice);
            userVal -= 1;
            string confirmedStudentID = listOfSearchResults[userVal].StudentID;

            Console.Clear();
            Console.WriteLine("-------------------");
            foreach(Student student in listOfStudents)
            {
                if(student.StudentID == confirmedStudentID)
                {
                    student.DisplayStudentDetails();
                }
            }
            foreach(GradeProfile gradeProfile in listOfGradeProfiles)
            {
                if(gradeProfile.StudentID == confirmedStudentID)
                {
                    gradeProfile.DisplayGradeProfile();
                }
            }
            Console.WriteLine("-------------------");
            Console.ReadKey(true);
        }

        static void AddStudent()
        {
            Console.Clear();
            Console.CursorVisible = true;
            Console.WriteLine("Student Grade System");
            Console.WriteLine("--------------------");
            Console.WriteLine("Enter New Student Details:");
            Console.WriteLine("Student ID: ");
            Console.WriteLine("First Name: ");
            Console.WriteLine("Last Name: ");
            Console.WriteLine("Date Of Birth (DD/MM/YYYY): ");
            Console.WriteLine("Contact Email: ");
            Console.WriteLine("--------------------");
            Console.SetCursorPosition(12,3);
            string studentID = Console.ReadLine();
            Console.SetCursorPosition(12,4);
            string firstName = Console.ReadLine();
            Console.SetCursorPosition(11,5);
            string lastName = Console.ReadLine();
            Console.SetCursorPosition(28, 6);
            string dateOfBirth = Console.ReadLine();
            Console.SetCursorPosition(15,7);
            string contactEmail = Console.ReadLine();
            listOfStudents.Add(new Student(studentID, firstName, lastName, dateOfBirth, contactEmail));
            listOfGradeProfiles.Add(new GradeProfile(studentID, "1"));
            bool addingGrades = true;
            while(addingGrades == true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                Console.WriteLine("Student Grade System");
                Console.WriteLine("--------------------");
                Console.WriteLine("Would you like to add a grade? (Y/N)");
                switch(Console.ReadKey(true).KeyChar)
                {
                    case 'y':
                        Console.Clear();
                        Console.CursorVisible = true;
                        Console.WriteLine("Student Grade System");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Enter New Grade Details:");
                        Console.WriteLine("Module: ");
                        Console.WriteLine("Assignment: ");
                        Console.WriteLine("Mark: ");
                        Console.WriteLine("Weight (as a decimal): ");
                        Console.WriteLine("--------------------");
                        Console.SetCursorPosition(8,3);
                        string module = Console.ReadLine();
                        Console.SetCursorPosition(12,4);
                        string assignment = Console.ReadLine();
                        Console.SetCursorPosition(6,5);
                        int mark = int.Parse(Console.ReadLine());
                        Console.SetCursorPosition(23,6);
                        decimal weight = decimal.Parse(Console.ReadLine());
                        listOfGradeProfiles.Find(x => x.StudentID == studentID).AddGrade(new Grade(module, assignment, mark, weight));
                        break;
                    case 'n':
                        addingGrades = false;
                        break;
                }
            }
        }
    }
}