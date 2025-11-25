public class Smartphone : ElectronicDevice
{
    // Constructor
    public Smartphone(string brand, double price) : base(brand, price)
    {
    }

    // Extra method
    public void EnableCamera()
    {
        Console.WriteLine("Smartphone camera enabled");
    }

    // Override ShowInfo()
    public override void ShowInfo()
    {
        Console.WriteLine($"Smartphone Brand: {Brand}\nPrice: {Price}");
    }
}
