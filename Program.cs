namespace SchoolAdmission;

class Program
{
    static void Main(string[] args)
    {
        School anjuman = new School();
        Student child1 = new Student("Akshay", 10, "5th Grade");
        Student child2 = new Student("Pujara", 9, "4th Grade");
        Student child3 = new Student("Chetana", 11, "6th Grade");

        anjuman.AddInformation(child1);
        anjuman.AddInformation(child2);
        anjuman.AddInformation(child3);

        anjuman.DisplayStidentInformation();
    }
}