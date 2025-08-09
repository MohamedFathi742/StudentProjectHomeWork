using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentProjectHomeWork.BL;
public class Student
{

    #region Ctor
    public Student()
    {
        StudentId = 0;
        Age = 18;
        Courses = new List<Courses>();
    }

    public Student(string name, int age, string major)
    {
        StudentId = 0;
        Name = name;
        Age = age;
        Major = major;
        Courses = new List<Courses>();
    }
    public Student(Student student)
    {
        StudentId = student.Age;
        Name = student.Name;
        Age = student.Age;
        Major = student.Major;
        Courses = new List<Courses>(student.Courses);
    }
    #endregion

    #region Prop
    public int StudentId { get; set; }
    string _Name;
    public string Name

    {
        set
        {
            if (value.Length <= 200)

                _Name = value;
            else
                Console.WriteLine("the max name length = 200 ");


        }
        get { return _Name; }

    }
    public string Major { get; set; }
    int _Age;
    public int Age

    {
        set
        {
            if (value >= 18)
                _Age = value;
            else
                Console.WriteLine(" min age 18");

        }
        get { return _Age; }


    }
    public List<Courses> Courses {  get; }
    #endregion

    #region Methods

    public void Print()
    {
        Console.WriteLine($@"""
                                Student Name {Name}
                                Student Major {Major}
                                Student Age {Age}
                                """
                          );

    }

    public void AddCourse(string courseName, int hours)
    {

        Courses.Add(new Courses (courseName, hours)
        {
        
        CourseName = courseName,
        Hours = hours
        
        });
    }
    public void AddCourse(Courses myCourses)
    {

        Courses.Add(
        myCourses
        );
    }


    public void PrintCourse()
    {
        foreach (var course in Courses)
        {
            Console.WriteLine($"Courses => {course.CourseName}");
        }



    }
    #endregion



  
}
