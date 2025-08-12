using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProjectHomeWork.BL;
public class Enrolment
{

    #region    PROP

    public Student Student { get; set; }
    public Courses Courses { get; set; }
    DateTime _EnrolmentDate;
    public DateTime EnrolmentDate
    {
        set
        {
            if (value >= DateTime.Now)

                _EnrolmentDate = value;
            else
                Console.WriteLine("cannot add time <  DateTime.Now");


        }

        get { return _EnrolmentDate; }
    }
    double _Grade;
    public double Grade
    {

        set
        {
            if (value > 0)
                _Grade = value;
            else
                Console.WriteLine("cannot add grad < 0");
        }
        get { return _Grade; }
    }
    #endregion

    #region CTOR

    public Enrolment()
    {
        Student = new Student();
        Courses = new Courses("", 0);
        EnrolmentDate = DateTime.Now;
        Grade = 0;
    }

    public Enrolment(Courses courses)
    {
        courses = new Courses("", 0);
    }
    public Enrolment(Enrolment enrolment)
    {
        Courses = new Courses(enrolment.Courses);
        Student = new Student(enrolment.Student);
        EnrolmentDate = enrolment.EnrolmentDate;
        Grade = enrolment.Grade;

    }
    #endregion



}
