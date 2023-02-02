namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input an integer: ");
        int n = Convert.ToInt16(Console.ReadLine());
        int m = n/2;
        int check = 0;

        if(n == 0 || n == 1){
            Console.WriteLine("N is non-prime");
            check=1;
        }

        for(int i = 2; i <= m; i++){
            if(n % i == 0){
                Console.WriteLine("N is non-prime");
                check=1;
                break;

            }

        }
        if(check==0){
            Console.WriteLine("N is prime");
        }
    }
}
