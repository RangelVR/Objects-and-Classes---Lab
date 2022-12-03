using System;
using System.Collections.Generic;

namespace Students
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
            List<Student> listOfStudents = new List<Student> ();

            string comand;

            while ((comand = Console.ReadLine()) != "end")
            {
                string[] dataOfStudent = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Student student = new Student()
                {
                    FirstName = dataOfStudent[0],
                    LastName = dataOfStudent[1],
                    Age = dataOfStudent[2],
                    HomeTown = dataOfStudent[3],
                };

                listOfStudents.Add(student);
            }

            string city = Console.ReadLine();
            var filteredStudents = listOfStudents.FindAll(student => student.HomeTown == city);

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is" +
                    $" {student.Age} years old.");
            }

            //foreach (Student student in listOfStudents)
            //{
            //    if (student.HomeTown == city)
            //    {
            //        Console.WriteLine($"{student.FirstName} {student.LastName} is" +
            //        $" {student.Age} years old.");
            //    }
            //}
        }
    }
}
