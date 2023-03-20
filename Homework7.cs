namespace Homework7;
class Program
{
    static void Main(string[] args)
    {
        Customer Alice = new Customer(cus_id:110, cus_name:"Alice", cus_age:28);
        Customer Bob = new Customer(cus_id:111, cus_name:"Bob", cus_age:30);
        Alice.PrintCusInfo();
        Bob.PrintCusInfo();
        Alice.ChangeID(new_id: 220);
        Bob.ChangeID(new_id: 221);
        Alice.PrintCusInfo();
        Bob.PrintCusInfo();
        Alice.CompareAge(Bob);
        
    }

    class Customer{
    private int cus_id;
    public string cus_name;
    public int cus_age;
    public int id;
    public string name;
    public int age;

    public Customer(int cus_id, string cus_name, int cus_age){
        id = cus_id;
        name = cus_name;
        age = cus_age;
    } //constructor used to assign id, name and age to the customer when an object is created.
    public void ChangeID(int new_id){
        id = new_id;
        

    } // method used to change customer id
    public void PrintCusInfo(){
        Console.WriteLine($"Customer:{id} Name:{name} Age:{age}");
        
    } // method used to print customer information(id, name, age)  
    public void CompareAge(Customer objCustomer){
        if(this.age <= objCustomer.age){
            Console.WriteLine($"{this.name} is older.");
        }else{
            Console.WriteLine($"{objCustomer.name} is older");
        }

    } // method used to compare the current object’s age with the objCustomer’s age. Then print out the cus_name of the older customer.
 
    }
}
