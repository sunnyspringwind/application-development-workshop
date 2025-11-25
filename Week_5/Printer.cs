/* Printer class with polimorphism */
public class Printer
{
    // polimorphed method
    public void Print(string message)
    {
        Console.WriteLine($"Message: {message}");

    }

    public void Print(int number)
    {
        Console.WriteLine($"Number: {number}");
    }

    public void Print(string message, int count)
    {
        Console.WriteLine($"Message: {message} \nCount: {count}");

    }
}