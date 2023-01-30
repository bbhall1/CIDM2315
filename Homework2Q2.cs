namespace Homework2Q2;
class Program
{
    static void Main(string[] args)
    {
    
        Console.WriteLine("Please input the first num: ");
        string num1 = Console.ReadLine();
        int user_num1 = Convert.ToInt16(num1);
        Console.WriteLine("Please input the second num: ");
        string num2 = Console.ReadLine();
        int user_num2 = Convert.ToInt16(num2);
        Console.WriteLine("Please input the third num: ");
        string num3 = Console.ReadLine();
        int user_num3 = Convert.ToInt16(num3);

        if(user_num1 <= user_num2){
            if(user_num1 <= user_num3){
                Console.WriteLine("The smallest value is: "+ user_num1);
        }
        else{
            Console.WriteLine("The smallest value is: " + user_num1);
        }
      }
        else{
            if(user_num2 <= user_num1){
                Console.WriteLine("The smallest value is: " + user_num2);
            }
            else
            Console.WriteLine("The smallest value is: " + user_num3);
        }
    }       
}   


