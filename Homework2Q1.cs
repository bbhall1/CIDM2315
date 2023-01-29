namespace Homework2Q1;
class Program
{
    static void Main(string[] args)
    {
    
        Console.WriteLine("Please input letter grade: ");
        string input_grade = Console.ReadLine();
        
        if(input_grade == "A"){
            Console.WriteLine("GPA point: 4");
        }
        else if(input_grade == "B"){
            Console.WriteLine("GPA Point: 3");
        }
        else if (input_grade == "C"){
            Console.WriteLine("GPA Point: 2");
        }
        else if (input_grade == "D"){
            Console.WriteLine("GPA Point: 1");
        }
        else if (input_grade == "F"){
            Console.WriteLine("GPA Point: 0");
        }
        else{
            Console.WriteLine("Wrong Letter Grade!");
        }
    }
}


