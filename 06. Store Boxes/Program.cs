using System;
using System.Collections.Generic;

namespace Students_2._0
{
    class Program
    {
        class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }

            public string HomeTown { get; set; }
        }


        static void Main(string[] args)
        {
            string inputStudent = Console.ReadLine();
            List<Student> listOfstudents = new List<Student>();

            while (inputStudent != "end")
            {
                string[] arr = inputStudent.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = arr[0];
                string lastName = arr[1];
                int age = int.Parse(arr[2]);
                string homeTown = arr[3];

                if (IsStudentExist(listOfstudents, firstName, lastName))
                {
                    Student student = GetExistingStudent(listOfstudents, firstName, lastName);

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
                else
                {
                    Student student = new Student();

                    student.FirstName = arr[0];
                    student.LastName = arr[1];
                    student.Age = int.Parse(arr[2]);
                    student.HomeTown = arr[3];

                    listOfstudents.Add(student);
                }

                inputStudent = Console.ReadLine();

            }

            string city = Console.ReadLine();


            foreach (Student student in listOfstudents)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is" +
                    $" {student.Age} years old.");
                }
            }

        }


        static bool IsStudentExist(List<Student> listOfstudents,
            string firstName, string lastName)
        {
            foreach (var student in listOfstudents)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }

        static Student GetExistingStudent (List<Student> listOfstudents, 
            string firstName, string lastName)
        {
            foreach (Student student in listOfstudents)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return student;
                }
            }
            return null;
        }
    }
}
