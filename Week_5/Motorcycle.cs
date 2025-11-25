public class Motorcycle : Vehicle
{
    // moterbike unique field
    private string color;

    //constructuor 
    public Motorcycle (string color)
    {
        this.color = color;
    }

    public string Color { get { return color; } set { color = value; } }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Color: {color}");
    }
}