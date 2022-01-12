using System;

namespace CarExercise
{
    class Program
    {
        public class Student
        {
            public string firstName;
            public string lastName;
            public int studentId;
            public string email;

            public Student()
            {
                Console.WriteLine("Olio luotu");
                this.firstName = string.Empty;
                this.lastName = string.Empty;
                this.email = string.Empty;
                this.studentId = -1;

            }
        }

        
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.firstName = "Matti";
            student1.studentId = 10123;
        }
    }
}
