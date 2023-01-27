namespace Homework2Q2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input first num: ");
        string  value1 = Console.ReadLine();
        
        int value1_int = Convert.ToInt16(value1);

        Console.WriteLine("Please input second num: ");
        string  value2 = Console.ReadLine();
        int value2_int = Convert.ToInt16(value2);

        Console.WriteLine("Please input third num: ");
        string  value3 = Console.ReadLine();
        int value3_int = Convert.ToInt16(value3);

        if(value1_int<value2_int){
            if(value1_int<value3_int){
                Console.WriteLine($"The smallest value is: {value1_int}");
            }
        }
        else{
            if(value2_int<value3_int){
                Console.WriteLine($"The smallest value is: {value2_int}");
            }
            if(value3_int<value2_int){
                Console.WriteLine($"The smallest value is: {value3_int}");
            }
        }

    }
}
