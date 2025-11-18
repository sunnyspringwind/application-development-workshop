public class Player
{
    // Instance fields
    public string? playerName;
    public int level;
    public int health;

    // 1. Default constructor
    public Player()
    {
        Console.WriteLine("Default constructor has been called");
    }

    // 2. Parameterized constructor
    public Player(string playerName, int level, int health)
    {
        this.playerName = playerName;
        this.level = level;
        this.health = health;
    }
}
