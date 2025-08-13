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
        Enrolments = new List<Enrolment>();
        MyMajor = new Major("", "");
    }

    public Student(string name, int age, string majorName, string drName)
    {
        StudentId = 0;
        Name = name;
        Age = age;
        MyMajor = new Major(majorName, drName);
        Enrolments = new List<Enrolment>();
    }
    public Student(Student student)
    {
        StudentId = student.Age;
        Name = student.Name;
        Age = student.Age;
        MyMajor = new Major(student.MyMajor.MajorName, student.MyMajor.DrName);
        Enrolments = new List<Enrolment>(student.Enrolments);
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
    public Major MyMajor { get; set; }
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
    public List<Enrolment> Enrolments { get; }
    #endregion

    #region Methods

    public void Print()
    {
        Console.WriteLine($"  Student Name => {Name}\n  Student Major => {MyMajor.MajorName}\nStudent Age => {Age}");

    }

    public void AddCourse(string courseName, int hours, DateTime enrolDate, double grad)
    {

        Enrolment enrolment = new Enrolment();
        enrolment.Student = this;
        enrolment.Courses = new Courses(courseName, hours);
        enrolment.EnrolmentDate = enrolDate;
        enrolment.Grade = grad;
        Enrolments.Add(enrolment);
    }
    public void AddCourse(Enrolment enrolment)
    {

        Enrolments.Add(
                enrolment
                       );
    }


    public void PrintCourse()
    {
        foreach (var enro in Enrolments)
        {
            Console.WriteLine($"Courses Name => {enro.Courses.CourseName}");
            Console.WriteLine($"Student Name => {enro.Student.Name}");
            Console.WriteLine($"Grad => {enro.Grade}");

        }



    }
    #endregion




}
