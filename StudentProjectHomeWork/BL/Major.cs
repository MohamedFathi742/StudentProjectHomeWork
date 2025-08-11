using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProjectHomeWork.BL;
public class Major
{
    #region Prop
    public int Id { get; set; }
    public string MajorName { get;  }
   public string DrName { get; }

    #endregion

    #region Ctor
    public Major(string majorName, string drName)
    {
        MajorName = majorName;
        DrName = drName;


    }
    public Major(Major major)
    {
        Id = major.Id;
        MajorName = major.MajorName;
        DrName = major.DrName;

    }
    #endregion


    #region Methods
    public void AddMajor(string majprName, string drName)
    {


        Major major = new Major(majprName, drName);


    }

    public void RemoveMajor(string majprName, string drName)
    {


        Major major = new Major(majprName, drName);


    } 
    #endregion

}
