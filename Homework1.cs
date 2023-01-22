namespace Homework1;
class Program
{
    static void Main(string[] args)
    {
        //Z = 4X2+3Y, when  X = 2.5, Y=3.3
        double x = 2.5;
        double y = 3.3;
        double z;
        // setting up X value
        Console.Write("X= " + x + ",");
        // setting up Y value, same line as X value with a tab space
        Console.WriteLine("\tY= " + y);
        // Z value plus formula to calculate Z
        Console.WriteLine("The value of Z is: " + (z=4*x*x+3*y));
    }
}
