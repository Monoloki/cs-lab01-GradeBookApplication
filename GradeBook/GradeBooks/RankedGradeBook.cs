﻿using System;
namespace GradeBook.GradeBooks
{
	public class RankedGradeBook: BaseGradeBook
	{
		public RankedGradeBook(string name, bool IsWeight) : base(name, IsWeight)
		{
			Type = Enums.GradeBookType.Ranked;
		}

		public override char GetLetterGrade(double averageGrade)
		{
			if (Students.Count < 5)
			{
				throw new System.InvalidOperationException("InvalidOperationException");
			}
			else
			{
				if (averageGrade >= 80)
					return 'A';
				else if (averageGrade >= 60)
					return 'B';
				else if (averageGrade >= 40)
					return 'C';
				else if (averageGrade >= 20)
					return 'D';
				else
					return 'F';
			}
		}
		public override void CalculateStudentStatistics(string name)
        {
			if(Students.Count < 5)
            {
				Console.WriteLine("Ranked grading requires at least 5 students.");
            }
			else
            {
				base.CalculateStudentStatistics(name);
			}

        }

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
