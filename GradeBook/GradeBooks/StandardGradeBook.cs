using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{

    //Creating StandardGradeBook class which inherits from BaseGradeBook class.
    public class StandardGradeBook : BaseGradeBook
    {
        //Creating StandardGradeBook constructor with name parameter which calls the constructor of the inherited class - base(name).
        //Refactoring constructor of StandardGradeBook.
        public StandardGradeBook(string name, bool IsWeighted) : base(name, IsWeighted)
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}
