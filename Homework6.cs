namespace Homework6;
class Program
{
    static void Main(string[] args)
    {
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.Salary = 9000;
        p1.Print();

        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.Salary = 8000;
        p2.Print();

        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.Grade = 90;
        s1.Print();

        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.Grade = 80;
        s2.Print();

        double salComp = (p1.Salary - p2.Salary);
        Console.WriteLine($"The salary difference between Alice and Bob is: {salComp}");

        double gradeComp = (s1.Grade + s2.Grade);
        Console.WriteLine($"The total grade of Lisa and Tom is: {gradeComp}");

        
        

        
    }

    class Professor{
        public string profName;
        public string classTeach;
        private double salary;
        public double Salary{
            get {return salary;}
            set {salary = value;}
        }

        public void Print(){
            Console.WriteLine($"Professor {profName} teaches {classTeach}, and the salary is: {salary}" );
        }

    }

    class Student{
        public string studentName;
        public string classEnroll;
        private double grade;
        public double Grade{
            get {return grade;}
            set {grade = value;}
        }
        public void Print(){
            Console.WriteLine($"Student {studentName} enrolls {classEnroll}, and the grade is: {grade}" );
        }
    }
}
