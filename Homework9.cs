namespace Homework9;
class Program
{
    public class Student
{
    private int studentID;
    private string studentName;

     public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
    public static List<Student> studentList = new List<Student>();

    public Student()
    {
        studentList.Add(this);
    }
    public Student(int id,string name) : this()
    {
        studentID = id;
        studentName = name;
        
    }

    public void PrintInfo()
        {
        Console.WriteLine("Student ID: " + studentID);
        Console.WriteLine("Student name: " + studentName);
        }
    }
    static void Main(string[] args)
    {
        // 2.Create 4 students with the following information

        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        //Dictionary to make student names student objects
        Dictionary<string, Student> students = new Dictionary<string, Student>()
        {
            { "Alice", alice },
            { "Bob", bob },
            { "Cathy", cathy },
            { "David", david }
        };

        //3. Create a Dictionary named gradebook
        Dictionary<string,double> gradebook = new Dictionary<string,double>()
        {
            { "Alice", 4.0 },
            { "Bob", 3.6 },
            { "Cathy", 2.5 },
            { "David", 1.8 }
        };

        //4. Check if "Tom" has a record in gradebook. If not insert him in with GPA of 3.3

        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
            students.Add("Tom", new Student(555, "Tom"));
        } 

    //5. Calculate the average GPA of all students, print out the average GPA

        double totalGPA = 0;
        foreach(var grade in gradebook)
        {
            totalGPA += grade.Value;
        }
        double averageGPA = totalGPA / gradebook.Count;
        Console.WriteLine("Average GPA: " + averageGPA);

    //6. Print out information about student whose GPA is greater than the average GPA

        Console.WriteLine("Students with GPA greater than average: ");

            foreach (var entry in gradebook)
            {
            if (entry.Value > averageGPA)
                {
                Console.WriteLine($"Student ID: {students[entry.Key].StudentID}, Student Name: {entry.Key}");
                }
            }
        }
    }
