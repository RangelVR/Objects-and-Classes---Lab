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
            List<Student> listOfStudents = new List<Student>();
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "end")
            {
                Student newStudent = new Student()
                { 
                    FirstName = command[0],
                    LastName = command[1],
                    Age = command[2],
                    HomeTown = command[3]
                };
                listOfStudents.Add(newStudent);
                command = Console.ReadLine().Split().ToArray();
            }

            string city = Console.ReadLine();
            
            foreach (Student student in listOfStudents)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age } years old.");
                }
            }

            //List<Student> filteredList = listOfStudents.Where(x => x.HomeTown == city).ToList();
            //foreach (Student student in filteredList)
            //{
            //    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age } years old.");
            //}
        }
    }

}
