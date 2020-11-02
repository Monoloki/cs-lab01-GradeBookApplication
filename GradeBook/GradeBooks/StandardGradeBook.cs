namespace GradeBook.GradeBooks
{
	public class StandardGradeBook: BaseGradeBook
	{
		public StandardGradeBook(string name,bool IsWeight) : base(name, IsWeight)
		{
			Type = Enums.GradeBookType.Standard;
		}

		
	}

}