namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
        /*Q1 Method
        CompareNum();
        */

        /*Q2 Method
        Stairs();
        */



    }



       /*Q1 Method Code
        static void CompareNum(){
        string  value1 = Console.ReadLine();
        
        int value1_int = Convert.ToInt16(value1);

        string  value2 = Console.ReadLine();
        
        int value2_int = Convert.ToInt16(value2);

        Console.WriteLine($"a = {value1_int}; b = {value2_int}");

        if(value1_int>=value2_int){
            Console.WriteLine($"The largest number is: {value1_int}");

        }else{
            Console.WriteLine($"The largest number is: {value2_int}");
        }
        

    }*/
        /*Q2 Method Code
        static void Stairs(){
        Console.WriteLine("Please input an integer");
        int size = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Right or Left?");
        string shape = Console.ReadLine();
        if(shape == "left"){
            
        
            for(int row=1; row <= size; row++){
                //For loop for columns, changed to compare to row in order to make the stair pattern.
                for(int column = 0; column < row; column++){
                Console.Write("#");
                }
            Console.WriteLine("");
            
            }

        }
        if(shape == "right"){
            int space = 0;
            int inner = 0;
            for (int row = 1; row <= size; row++)
            {
                for (space = size; space > row; space--)
                {
                    Console.Write(" ");
                }
                for (inner = 0; inner < row; inner++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        
            
    }*/
    



}
