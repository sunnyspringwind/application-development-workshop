namespace AppDev.Week_4
{
	/// <summary>
    /// a student class with id,name,desc,FavColor
    /// </summary>
	public class Student
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public static string School { get; set; } = "IIC";

	}
}