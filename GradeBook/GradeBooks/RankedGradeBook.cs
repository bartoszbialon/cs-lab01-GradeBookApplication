using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    //Creating RankedGradeBook class which inherits from BaseGradeBook class.
    public class RankedGradeBook : BaseGradeBook
    {
        //Creating RankedGradeBook constructor with name parameter which calls the constructor of the inherited class - base(name).
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        //Overriding RankedGradeBook's GetLetterGrade method.
        public override char GetLetterGrade(double averageGrade)
        {
            int N = 0;

            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].AverageGrade >= averageGrade)
                {
                    N++;
                }
            }

            //If there are less than 5 students -> throw InvalidOperationException.

            if (Students.Count < 5)
            {
                throw new InvalidOperationException(); 
            }

            double grade_percent = Convert.ToDouble(N) / Convert.ToDouble(Students.Count) * 100;


            //Return A if the input grade is in the top 20% of the class.
            if (grade_percent <= 20)
            {
                return 'A';
            }

            //Return B if the input grade is between the top 20 and 40 % of the class.
            else if (grade_percent > 20 && grade_percent <= 40)
            {
                return 'B';
            }

            //Return C if the input grade is between the top 40 and 60% of the class.
            else if (grade_percent > 40 && grade_percent <= 60)
            {
                return 'C';
            }

            //Return D if the input grade is between the top 60 and 80% of the class.
            else if (grade_percent > 60 && grade_percent <= 80)
            {
                return 'D';
            }


            //Return F if the grade is below the top 80% of the class.
            else
            {
                return 'F';
            }

        }

        //Overriding RankedGradeBook's CalculateStatistics method.
        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }

            else
            {
                base.CalculateStatistics();
            }
        }

    }
}
