
public class NullOperations
{
    public static void PerformNullOperations()
    {
        string? username = "Superman";
        Console.WriteLine(username == null ? "Username is not available" : $"Username: {username}");

        //   null coalescing Doesn’t change original variable
        Console.WriteLine(username ?? "Lancelot");

        // null coalescing assignment Updates variable itself
        username ??= "Adolf";
        Console.WriteLine(username);

    }


}