using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProjectHomeWork.BL;
public class Enrolment
{
    public  Student Student  { get; set; }
    public  Courses Courses   { get; set; }
    public DateTime EnrolmentDate { get; set; }
    public double  Grade { get; set; }


    public Enrolment()
    {
        Student = new Student();
        Courses = new Courses("",0 );
    }

    public Enrolment(Courses courses)
    {
         
    }

}
