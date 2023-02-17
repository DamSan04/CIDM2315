namespace Homework5;
class Program
{
    static void Main(string[] args)
    {

        /*Q1
        int num1, num2, num3, num4;

        int max1 = getNums(out num1, out num2);
        Console.WriteLine($"a = {num1}; b = {num2};");
        Console.WriteLine($"The largest number is: {max1}");
        */




        /*Q2
        int max1 = getNums(out num1, out num2);
        int max2 = getNums(out num3, out num4);
        int max3 = 0;
        if(max1>=max2){
            max3 = max1;
        }else{
            max3 = max2;
        }
        Console.WriteLine($"a = {num1}; b = {num2}; c = {num3}; d = {num4};");
        Console.WriteLine($"The largest number is: {max3}");
        */


        /*Q3
        createAccount();
        */
    }
        /*Q1 and Q2 method
    static int getNums(out int int_input, out int int_input2){
        string str_input = Console.ReadLine();
        int_input = Convert.ToInt16(str_input);
        string str_input2 = Console.ReadLine();
        int_input2 = Convert.ToInt16(str_input2);
        
        
        
        if(int_input>=int_input2){
            return int_input;
        }else{
            return int_input2;
        }

        
        
    }*/
    /*Q3 Method
    static bool checkAge(int birthyear){
	    // calculate the age based on the birth_year (age = 2022-birthyear)
        int age = 2022 - birthyear;
	    // if age >=18, return true;
        if(age >= 18){
            return true;
        }else{
            return false;
        }
	    //else return false;
    }
    static void createAccount(){
        // ask user to input username
        Console.WriteLine("Input a username.");
        string username = Console.ReadLine();
        // ask user to input password
        Console.WriteLine("Input a password.");
        string password1 = Console.ReadLine();
        // ask user to input password again
        Console.WriteLine("Input password again.");
        string password2 = Console.ReadLine();
        // ask user to input birthyear
        Console.WriteLine("Input birthyear.");
        string str_birthyear = Console.ReadLine();
        int int_birthyear = Convert.ToInt16(str_birthyear);
        // call checkAge(birthyear) method to check if age is greater than 18
        bool ageCheck = checkAge(int_birthyear);
        // if checkAge(birthyear) returns true,
        if(ageCheck == true){
            if(password1 == password2){
                Console.WriteLine("Account is created successfully");
            
            }else{
                Console.WriteLine("Wrong Password");
            }
        }else{
            Console.WriteLine("Could not create an account");
        } 
            //then check if two passwords are same, if passwords are same, print “Account is created successfully”
            // else print “Wrong password”
	    // if checkAge(birthyear) returns false, print “Could not create an account”
    }*/ 







}



