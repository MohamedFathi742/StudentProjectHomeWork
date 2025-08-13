using StudentProjectHomeWork.BL;

namespace StudentProjectHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Student grade project");
            Student student1 = new Student();
            Console.WriteLine("------------***********------------");

            Console.WriteLine("please enter student name");
            student1.Name = Console.ReadLine()!;
            Console.WriteLine("------------***********------------");

            Console.WriteLine("please enter student major");
            student1.MyMajor = new Major(Console.ReadLine()!, "");
            Console.WriteLine("------------***********------------");

            Console.WriteLine("please enter student age");
            bool isConverted = false;
            int sAge = 0;
            isConverted = int.TryParse(Console.ReadLine(), out sAge);
            if (!isConverted)
            {
                Console.WriteLine("please enter valid age");
                return;
            }
            student1.Age = sAge;
            Console.WriteLine("------------***********------------");

            Courses courses;

            Enrolment enrolment;

            Console.WriteLine("Now you will add Student Course");
            Console.WriteLine("------------***********------------");
            char sUserInput = 'x';
            while (sUserInput != 'q')
            {

                Console.WriteLine("please enter course name ");
                string courseName= Console.ReadLine()!;
                Console.WriteLine("------------***********------------");
                Console.WriteLine("please enter course hours");
                int courseHours = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("------------***********------------");
                courses = new Courses(courseName!, courseHours);

                enrolment = new Enrolment();
                enrolment.Student = student1;
                enrolment.Courses = courses;
                enrolment.EnrolmentDate = DateTime.Now.AddSeconds(1);
                Console.WriteLine("------------***********------------");
                Console.WriteLine("please enter course Grade ");
                enrolment.Grade= Convert.ToDouble( Console.ReadLine());
                Console.WriteLine("------------***********------------");
                student1.AddCourse(enrolment);

                Console.WriteLine("for exist press q");
                
                    sUserInput = Convert.ToChar(Console.ReadLine()!);

                Console.WriteLine("------------***********------------");
            }
            Console.WriteLine("------------***********------------");
            Console.WriteLine("student info");
            student1.Print();
            Console.WriteLine("------------***********------------");
            Console.WriteLine("student Course info");
            student1.PrintCourse();

        }
    }
}
