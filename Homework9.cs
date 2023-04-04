namespace Homework9;
class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        if(gradebook.ContainsKey("Tom"))
        {
            Console.WriteLine("");
        }
        else
        {
            gradebook.Add("Tom", 3.3);
        }
        
        double sumGPA=gradebook.Values.Sum();
        double avgGPA=sumGPA/gradebook.Count();

        Console.WriteLine($"The average GPA is: {avgGPA}");


        foreach(var x in Student.student_list)
        {
            if(gradebook[x.studentName]>avgGPA)
            {
                x.PrintInfo();
            }
        }

    }
}

class Student
{
    public static List<Student> student_list = new List<Student>();
    public int studentID { get; set; }
    public string studentName { get; set; }
    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
    public Student(int inputID, string inputName)
    {
        studentID = inputID;
        studentName = inputName;
        student_list.Add(this);
    }

    


}
