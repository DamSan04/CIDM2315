namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
        //Homework 3 (Remove /*,*/ comments for code per question)





        //Question 1

        //Asking and getting Input
        /*Console.WriteLine("Input an integer: "); 
        int n = Convert.ToInt16(Console.ReadLine());
        int m = n/2;
        int check = 0; //used to break loop


        //Checks for 0 and 1, special cases
        if(n == 0 || n == 1){
            Console.WriteLine("N is non-prime");
            check=1;
        }


        //Checks for non-prime and if true changes value of the check
        for(int i = 2; i <= m; i++){
            if(n % i == 0){
                Console.WriteLine("N is non-prime");
                check=1;
                break;

            }

        }


        //Used after the for loop checking for prime
        if(check==0){
            Console.WriteLine("N is prime");*/





        //Question 2

        //Asking and getting input
        /*Console.WriteLine("Please input an integer");
        int size = Convert.ToInt16(Console.ReadLine());


        //For loop for rows
        for(int row=0; row < size; row++){
            //For loop for columns
            for(int column = 0; column < size; column++){
                Console.Write("#");
            }
            Console.WriteLine("");
            
        }*/


        //Question 3

        //Asking and getting input
        /*Console.WriteLine("Please input an integer");
        int size = Convert.ToInt16(Console.ReadLine());


        //For loop for rows
        for(int row=1; row <= size; row++){
            //For loop for columns, changed to compare to row in order to make the stair pattern.
            for(int column = 0; column < row; column++){
                Console.Write("#");
            }
            Console.WriteLine("");
            
        }*/
     
            
        
    }
}
