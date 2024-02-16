namespace SchoolAdmission;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }

    public Student(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }
}
class School
{
    private List<Student> admission;
    public School()
    {
        admission = new List<Student>();
    }

    public void AddInformation(Student student)
    {
        admission.Add(student);
    }

    public void DisplayStidentInformation()
    {
        foreach (var item in admission)
        {
            Console.WriteLine($"Student Name:{item.Name} \nAge: {item.Age} \nGrade: {item.Grade} \n");
        }
    }
}
