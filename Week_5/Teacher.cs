public class Teacher
{
    public int Name { get; set; }

    public virtual void Teaching()
    {
        Console.WriteLine("Teacher teaches in English");
    }

    public void SalaryInfo()
    {
        Console.WriteLine("Cannot override salary.");
    }

}