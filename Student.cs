using System;

namespace GradeSystem
{
    public class Student
    {
        private string studentID;
        private string firstName;
        private string lastName;
        private string dateOfBirth;
        private string email;

        public string StudentID 
        {
            get { return studentID; }
        }

        public string FirstName
        {
            get { return firstName; }
        }
        public string LastName
        {
            get { return lastName; }
        }
        /*public string DateOfBirth
        {
            get { return dateOfBirth; }
        }*/
        /*public string Email
        {
            get { return email; }
        }*/

        public Student(string studentID, string firstName, string lastName, string dateOfBirth, string email)
        {
            this.studentID = studentID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.email = email;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine(firstName + " " + lastName + " (" + studentID + ")");
            Console.WriteLine("DOB: " + dateOfBirth);
            Console.WriteLine("Contact: " + email);
        }
    }
}