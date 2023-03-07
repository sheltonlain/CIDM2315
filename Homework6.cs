namespace Homework6;
class Program
{
    static void Main(string[] args)
    {
        Student student1= new Student();
        student1.studentName="Lisa";
        student1.classEnroll="Java";
        student1.SetGrade(90);

            

        Student student2= new Student();
        student2.studentName="Tom";
        student2.classEnroll="Math";
        student2.SetGrade(80);

        Professor professor1= new Professor();
        professor1.profName="Alice";
        professor1.classTeach="Java";
        professor1.SetSalary(9000);

        Professor professor2= new Professor();
        professor2.profName="Bob";
        professor2.classTeach="Math";
        professor2.SetSalary(8000);

        Console.WriteLine($"Professor {professor1.profName} teaches {professor1.classTeach}, and the salary is: {professor1.GetSalary()}");
        Console.WriteLine($"Professor {professor2.profName} teaches {professor2.classTeach}, and the salary is: {professor2.GetSalary()}");
        
        Console.WriteLine($"Student {student1.studentName} enrolls {student1.classEnroll}, and the grade is: {student1.GetGrade()}");
        Console.WriteLine($"Student {student2.studentName} enrolls {student2.classEnroll}, and the grade is: {student2.GetGrade()}");
        
        Console.WriteLine($"The total salary difference bewtween {professor1.profName} and {professor2.profName} is: {professor1.GetSalary()-professor2.GetSalary()}");
        Console.WriteLine($"The total grade of {student1.studentName} and {student2.studentName} is: {student1.GetGrade()+student2.GetGrade()}");
    }
}

class Student
{
    public string studentName;
    public string classEnroll;
    private double studentGrade;

    public void SetGrade(double newGrade)
    {
        studentGrade=newGrade;
    }

    public double GetGrade()
    {
        return studentGrade;
    }
}

class Professor
{
    public string profName;
    public string classTeach;
    private double salary;

    public void SetSalary(double salary_amount)
    {
        salary=salary_amount;
    }

    public double GetSalary()
    {
        return salary;
    }
}
