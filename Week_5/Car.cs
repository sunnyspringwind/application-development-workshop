public class Car : Vehicle
{
     int seats;

    // construcuter to assign seats
    public Car(int seats)
    {
        this.seats = seats;
    }

    // overriding display info
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Seats: {seats}"); 
    }
}