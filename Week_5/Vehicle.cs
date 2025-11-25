public class Vehicle
{
    
    //properties
    public string Brand { get; set; }
    public int Speed { get; set; }

    // start method
    public void Start()
    {
        Console.WriteLine("Vehicle Started!");
    }

    // stop method
    public void Stop()
    {
        Console.WriteLine("Vehicle Stopped!");
    }

    // Display info method
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand} \nSpeed: {Speed}km/h");
    }
}