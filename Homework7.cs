namespace Homework7;
class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer(inputcus_id: 110, inputcus_name: "Alice", inputcus_age: 28);
    
        Customer c2 = new Customer(inputcus_id: 111, inputcus_name: "Bob", inputcus_age: 30);

        c1.PrintCusInfo();
        c2.PrintCusInfo();

        c1.ChangeID(new_id: 220);
        c2.ChangeID(new_id: 221);

        c1.PrintCusInfo();
        c2.PrintCusInfo();

        c1.CompareAge(c2);


    }
}

class Customer{
    
    private int cus_id = 0;
    public string cus_name = string.Empty;
    public int cus_age = 0;

    public Customer(int inputcus_id, string inputcus_name, int inputcus_age){
        cus_id = inputcus_id;
        cus_name = inputcus_name;
        cus_age = inputcus_age;
        }

        public void ChangeID(int new_id){
            cus_id = new_id;
        }
        
        public void PrintCusInfo(){
            Console.WriteLine($"Customer: {cus_id}");
            Console.WriteLine($"Name: {cus_name}");
            Console.WriteLine($"Age: {cus_age}");
        }
            public int inputcus_age {get;set;} = 0;
            public string inputcus_name {get; set;} = string.Empty;
            public Customer(int inputcus_age, string inputcus_name){
                this.cus_age = inputcus_age;
                this.cus_name = inputcus_name;
            }

        public void CompareAge(Customer objCustomer){
            if( this.cus_age > objCustomer.cus_age){
            Console.WriteLine($"{cus_name} is older.");
            }
            else{
                Console.WriteLine($"{objCustomer.cus_name} is older.");
            }
        }
    }
