namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*****Question 1*****");
        int num;
        bool isPrime = true;

        Console.WriteLine("Input an integer:");
        num = Convert.ToInt32(Console.ReadLine());

        for(int i=2; i<=num/2; i++)             
        {
            if(num%i == 0)
            {
                isPrime = false;
                Console.WriteLine("N is non-prime");
                break;
            }
        }
        if(num < 2)
        {
            Console.WriteLine("N is non-prime");
            return;
        }
        if(isPrime)
        {
            Console.WriteLine("N is prime");
        }
    }
}

namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*****Question 2*****");
        Console.WriteLine("Assign an int value to N:");
        int j = Convert.ToInt32(Console.ReadLine());

        for(int row = 0; row<j; row++)
        {
            for(int col=0; col < j; col++)
            {Console.Write('*');
            }
        Console.WriteLine("");
        }
    }    
} 

namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*****Question 3*****");
        Console.WriteLine("Assign an int value to N:");
        int k = Convert.ToInt32(Console.ReadLine());

        for(int row = 0; row < k; row++)
        {
            for(int col = 0; col < k; col++)
    {
        if(row >= col)
            Console.Write('*');
    }
            Console.WriteLine("");
        }

    }    
} 