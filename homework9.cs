namespace Homework9;
class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student Bob = new Student(222, "Bob");
        Student Cathy = new Student(333, "Cathy");
        Student David = new Student(444, "David");

        Dictionary<string,double> gradebook= new Dictionary<string, double>();
        gradebook.Add("Alice",4.0);
       gradebook.Add("Bob",3.6);
        gradebook.Add("Cathy",2.5);
        gradebook.Add("David",1.8);
    if(gradebook.ContainsKey("Tom")){Console.WriteLine("Tom is in dictionary");}
    else{gradebook.Add("Tom",3.3);}
   
    double sumGPA = gradebook.Values.Sum();
        double avgGPA = sumGPA / gradebook.Count;

        Console.WriteLine($"The average GPA is :{avgGPA}");
       foreach (Student stu in Student.studentList){
        if (gradebook[stu.stuName]>avgGPA){
            stu.PrintInfo();
     }
     
   

    }}
    

class Student{
   
    private int stuID { get; set; }
    public string stuName { get; set; }
    public void PrintInfo(){
        Console.WriteLine($"Student ID: {stuID}, Student Name: {stuName}");
    }
    public static List<Student> studentList = new List<Student>();
    public Student(int inputID, string inputName){
        stuID = inputID;
        stuName = inputName;
        studentList.Add(this);
    }
   
}
 }