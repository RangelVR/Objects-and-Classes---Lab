string studentInfo = Console.ReadLine();

List<Student> students = new List<Student>();

while (studentInfo != "end")
{
    string[] infoArr = studentInfo.Split();

    string firstName = infoArr[0];
    string lastName = infoArr[1];
    int age = int.Parse(infoArr[2]);
    string homeTown = infoArr[3];

    if (students.Any(x => x.FirstName == firstName && x.LastName == lastName))
    {
        foreach (Student student in students)
        {
            if (student.FirstName == firstName && student.LastName == lastName)
            {
                student.Age = age;
                student.HomeTown = homeTown;
                break;
            }
        }
    }
    else
    {
        Student newStudent = new Student
        {
            FirstName = firstName,
            LastName = lastName,
            Age = age,
            HomeTown = homeTown
        };
        students.Add(newStudent);
    }
    
    studentInfo = Console.ReadLine();
}

string town = Console.ReadLine();

List<Student> filteredStudents = students.Where(x => x.HomeTown == town).ToList();

foreach (Student student in filteredStudents)
{
    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
}



class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public string HomeTown { get; set; }
}
