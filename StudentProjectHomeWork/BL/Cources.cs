using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProjectHomeWork.BL;
public class Cources
{
    #region Prop
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
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

    public void AddCourse(string courseName)
    {

        Cources.Add(new Cources(courseName, 3)
        {

            Name = courseName,
            Hours = 3
        });
    }


    public Cources( string name , int hours)
    {
       
        Name = name;
      Hours = hours;
    }


}
