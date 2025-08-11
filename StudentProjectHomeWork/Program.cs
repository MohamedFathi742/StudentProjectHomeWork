using StudentProjectHomeWork.BL;

namespace StudentProjectHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Student grade project");
            Student student1 = new Student();
            Console.WriteLine("please enter student name" );
            student1.Name = Console.ReadLine()!;
            Console.WriteLine("please enter student major" );
            student1.MyMajor=new Major(Console.ReadLine()!,"");
            Console.WriteLine("please enter student age");
            bool isConverted= false;
            int sAge = 0;
            isConverted =int.TryParse( Console.ReadLine(), out sAge);
            if (!isConverted)
            {
                Console.WriteLine("please enter valid age");
                return;
            }
            student1.Age = sAge;
            Courses courses;
            char sUserInput = 'x';
            while (sUserInput!='q')
            {

                Console.WriteLine("please enter course name and hours");

                 courses=new Courses(Console.ReadLine(),Convert.ToInt32( Console.ReadLine()));
                student1.AddCourse(courses);
                Console.WriteLine("for exist press q");
                sUserInput=Convert.ToChar(Console.ReadLine()!);
            }
            student1.Print();
            student1.PrintCourse();

        }
    }
}
