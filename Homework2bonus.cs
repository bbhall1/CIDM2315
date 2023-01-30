namespace Homework2bonus;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a year : ");
        string year = Console.ReadLine();
        int year_input = Convert.ToInt16(year);
        
        if((year_input % 4 == 0) && (year_input % 100 != 0) || (year_input % 400 ==0))
        {
            Console.WriteLine(year_input + " " + "is a Leap Year.");
        }
        else{
            Console.WriteLine(year_input + " " + "is not a Leap Year.");
        }
    }
}
