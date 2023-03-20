using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    //Creating RankedGradeBook class which inherits from BaseGradeBook class
    public class RankedGradeBook : BaseGradeBook
    {
        //Creating RankedGradeBook constructor with name parameter which calls the constructor of the inherited class - base(name)
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }
    }
}
