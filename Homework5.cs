namespace Homework5;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------Question 1-------\n\n");

        Console.Write("a= ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b= ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        int biggest = MaxInt(a, b);
        Console.WriteLine("The largest number is: " + biggest);
       
    }
    static int MaxInt(int a,int b)
    {
        if( a > b){
            return a;
        }

        else{
            return b;
        }
        
    }
}


namespace Homework5;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------Question 2-------\n\n");

        Console.Write("a= ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b= ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("c= ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.Write("d= ");
        int d = Convert.ToInt32(Console.ReadLine());
        
        int biggest2 = MaxInt2(a, b, c, d);
        Console.WriteLine("The largest number is: " + biggest2);
       
    }
    static int MaxInt(int a,int b) //question 1 
    {
        if( a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    static int MaxInt2 (int a, int b, int c, int d) //question 2
    {
        int comp1 = MaxInt (a,b);
        int comp2 = MaxInt (c,d);

        int biggest2 = MaxInt (comp1,comp2);
        return biggest2;
    }
}