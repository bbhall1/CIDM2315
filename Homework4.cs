namespace Homework4;
class Program
{
    static void Main(string[] args)
{
    Console.WriteLine("---Question 1---");
    Console.Write("Enter number: ");
    int num1 = Convert.ToInt16(Console.ReadLine());

    Console.Write("Enter number: ");
    int num2 = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("The largest number is: " + numHigh(num1, num2));
}

    public static int numHigh(int num1, int num2)
    {
        return num1 > num2 ? num1 : num2;
    }
}



namespace Homework4;
class Program
{
    static void Main(string[] args)
{
    Console.WriteLine("---Question 2---\n\n");
       
            Console.WriteLine("Insert a number: ");
            int j = Convert.ToInt32(Console.ReadLine());
           
           string directL = "{left}";
           string directR = "{right}";
           string direction = (directL + directR);
           int numN = j;          
           Console.WriteLine("Pick a direction: ");
           direction = Console.ReadLine();

        
        triangleLeft(numN,directL);
        triangleRight (numN,directR);

     
        static void triangleLeft (int numN, string directL)
        {            
            Console.WriteLine($"N is {numN}; the shape is {directL}");

            for(int row = 0; row < numN; row++)
            {
            for(int col = 0; col < numN; col++)
            {
                if(row >= col)
            Console.Write('*');
            }
            Console.WriteLine("");
            }
            
        }
        static void triangleRight(int numN, string directR)
        {
            Console.WriteLine($"N is {numN}; the shape is {directR}");
            
            for (int row = 1; row <= numN; row++)  
         {  
            for (int col = 1; col <= numN-row; col++)  
            {  
               Console.Write(" ");  
            }  
            for (int i = 1; i <= row; i++)  
            {  
               Console.Write("*");  
            }  
            Console.WriteLine("");  
         }  
    }
}
}
        
        