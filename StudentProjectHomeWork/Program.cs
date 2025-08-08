using StudentProjectHomeWork.BL;

namespace StudentProjectHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Student student = new Student();
            student.Print("Please enter name");
           string name= Console.ReadLine();
            student.Name = name;


        }
    }
}
