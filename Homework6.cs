namespace Homework6;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------Question 1-------\n");
        Professor p1 = new Professor();
        
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(9000);
        Console.WriteLine($"The first professor is {p1.profName}, she teaches {p1.classTeach}, her salary is {p1.GetSalary()}");
      
        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary(8000);
        Console.WriteLine($"The second professor is {p2.profName}, he teaches {p2.classTeach}, his salary is {p2.GetSalary()}");

        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.setGrade(90);
        Console.WriteLine($"The first student is {s1.studentName}, she enrolls {s1.classEnroll}, the grade is {s1.GetGrade()}");

        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.setGrade(80);
        Console.WriteLine($"The second student is {s2.studentName}, he enrolls {s2.classEnroll}, the grade is {s2.GetGrade()}");
    }
}


class Professor{
    public string profName;
    public string classTeach;
    private double salary;  
       
    public void SetSalary(double salary_amount){
        salary = salary_amount;
    }
    public double GetSalary(){
        return salary;
        }
    }

class Student{
    public string studentName;
    public string classEnroll;
    private double studentGrade;
    public void PrintInfo(){
    }

    public void setGrade(double newGrade){
        studentGrade = newGrade;
    }
    public double GetGrade(){
        return studentGrade;
    }
}


namespace Homework6;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------Question 2-------\n");
        Professor p1 = new Professor();
        
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(9000);
        Console.WriteLine($"Professor {p1.profName} teaches {p1.classTeach}, and the salary is: {p1.GetSalary()}");
      
        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary(8000);
        Console.WriteLine($"Professor {p2.profName} teaches {p2.classTeach}, and the salary is: {p2.GetSalary()}");

        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.setGrade(90);
        Console.WriteLine($"Student {s1.studentName}, he teaches {s1.classEnroll}, his salary is {s1.GetGrade()}");

        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.setGrade(80);
        Console.WriteLine($"The second student is {s2.studentName}, he teaches {s2.classEnroll}, his salary is {s2.GetGrade()}");

        double SalaryDiff = (9000-8000);
        Console.WriteLine($"The salary difference between {p1.profName} and {p2.profName} is: {SalaryDiff}");

        double GradeSum = (90+80);
        Console.WriteLine($"The total grade of {s1.studentName} and {s2.studentName} is: {GradeSum}");

    }
}

class Professor{
    public string profName;
    public string classTeach;
    private double salary;    
       
    public void SetSalary(double salary_amount){
        salary = salary_amount;
    }
    public double GetSalary(){
        return salary;
        }
    }

class Student{
    public string studentName;
    public string classEnroll;
    private double studentGrade;
    
    public void PrintInfo(){
    }

    public void setGrade(double newGrade){
        studentGrade = newGrade;
    }
    public double GetGrade(){
        return studentGrade;
    }
}

