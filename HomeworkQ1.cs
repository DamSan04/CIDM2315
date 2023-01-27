namespace Homework2;
class Program
{
    static void Main(string[] args)
    {
        //Asking for letter grade input.
        Console.WriteLine("Please input a letter grade: ");
        string letter_grade = Console.ReadLine();
        
        if(letter_grade == "A" || letter_grade == "B" || letter_grade == "C" || letter_grade == "D" || letter_grade == "F"){
            if(letter_grade == "A"){
                Console.WriteLine("GPA Point: 4");

            }
            if(letter_grade == "B"){
                Console.WriteLine("GPA Point: 3");

            }
            if(letter_grade == "C"){
                Console.WriteLine("GPA Point: 2");

            }
            if(letter_grade == "D"){
                Console.WriteLine("GPA Point: 1");

            }
            if(letter_grade == "F"){
                Console.WriteLine("GPA Point: 0");

            }

        }
        else{
            Console.WriteLine("Wrong Letter Grade!");
        } 
    }
}
