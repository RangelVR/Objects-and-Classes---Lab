using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Age { get; set; }
            public string HomeTown { get; set; }
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "end")
            {
                string firstName = command[0];
                string lastName = command[1];
                string age = command[2];
                string homeTown = command[3];
               
                if (IsStudentExisting(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName);
                    
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
                else
                {
                    Student newStudent = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = homeTown
                    };

                    students.Add(newStudent);
                }
                
                command = Console.ReadLine().Split().ToArray();
            }

            string city = Console.ReadLine();
            
            foreach (Student student in students)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age } years old.");
                }
            }
            
        }


        static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }


        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }
    }

}
