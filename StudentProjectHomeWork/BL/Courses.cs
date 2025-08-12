using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProjectHomeWork.BL;
public class Courses
{
    #region Prop
    public int CourseId { get; set; }
    public string CourseName { get; set; } = string.Empty;
    int _Hours;
    public int Hours
    {
        set
        {

            if (value >= 3)
                _Hours = value;
            else
                Console.WriteLine("cannot Hours of course <3");
        }

        get
        {

            return _Hours;

        }

    }
    #endregion

    public void AddCourse(string courseName, int hours)
    {

        //Cources.Add(new Cources(courseName, 3)
        //{

        //    Name = courseName,
        //    Hours = 3
        //});
    }


    public Courses(string name, int hours)
    {

        CourseName = name;
        Hours = hours;
    }
    public Courses(Courses courses)
    {

        CourseId = courses.CourseId;
        CourseName = courses.CourseName;
        Hours = courses.Hours;

    }

}
