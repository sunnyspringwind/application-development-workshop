namespace AppDev.Week_6
{
    public class Student(string name, string major, int rating)
    {
        public string Name { get; set; } = name;
        public string Major { get; set; } = major;

        public int Rating { get; set; } = rating;
    }
}