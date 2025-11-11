public class Week2 {

    public void Tasks() {
    
    // Task 1
        string userName;
        int luckyNumber;
        userName = "Ashish Limbu"; luckyNumber = 1;
        Console.WriteLine($"Hello, ${userName}! Your Lucky Number is ${luckyNumber}");


        // Task 2
        /*
        Trynna change const var.
        Circle.PI = 1.12; 
        Error:  error CS0131: The left-hand side of an assignment must be a variable, property or indexer
        const values are compile-time constants.
        They are embedded directly into the compiled code, not stored in memory as a regular variable. 
        This means they cannot be modified anywhere, ever.
        */
        // Printing Area and Perimeter
        Console.WriteLine($"Area of Circle: ${Circle.AreaOfCirlce(12)}");
        Console.WriteLine($"Perimeter of Circle: ${Circle.PerimeterOfCircle(12)}");


        // Task 3
        // Declare and initialize variables
        byte b = 255;
        short s = -32000;
        int i = 42;
        long l = 1234567890123L;
        float f = 3.14f;
        double d = 3.14159;
        decimal dec = 12.345m;
        char ch = 'A';
        bool bo = true;

        // Conversions
        string intAsString = i.ToString();
        double parsedPi = double.Parse("3.14");

        // Print variables with type labels
        Console.WriteLine($"byte: {b}");
        Console.WriteLine($"short: {s}");
        Console.WriteLine($"int: {i}");
        Console.WriteLine($"long: {l}");
        Console.WriteLine($"float: {f}");
        Console.WriteLine($"double: {d}");
        Console.WriteLine($"decimal: {dec}");
        Console.WriteLine($"char: {ch}");
        Console.WriteLine($"bool: {bo}");
        Console.WriteLine($"int -> string: \"{intAsString}\" (type: {intAsString.GetType()})");
        Console.WriteLine($"\"3.14\" -> double: {parsedPi}");


        // Task 4
        // Creates a single-dimensional integer array containing 5 of your favorite numbers.
        int[] favNumbers = [1, 47, 58, 7, 10];

        // Uses Array.Sort() to sort the array in ascending order.
        Array.Sort(favNumbers);

        // Prints each element of the array using a for loop.
        Console.WriteLine("Printing Favourite Numbers in Order");
        for (int idx = 0; idx < favNumbers.Length; idx++)
        {
            Console.WriteLine(favNumbers[i]);
        }

        // Uses Array.Reverse() to reverse the sorted array.
        Array.Reverse(favNumbers);

        // Uses Array.IndexOf() to find the position of a specific number in the array.
        var numdex = Array.IndexOf(favNumbers, 10);
        Console.WriteLine($"Index of 10: ${numdex}");


        // Task 5: Date Time and Time Span [10 minutes]

        // Creates a DateTime variable representing your birthdate.
        DateTime dob = new(2001, 11, 25);
        // Creates another DateTime variable representing the current date and time.
        DateTime now = DateTime.UtcNow;
        // Calculates your age using TimeSpan (you'll need to subtract the two DateTime values).
        var age = dob - now;
        // Prints your birthdate, the current date, and your age in years.
        Console.WriteLine($"Birth Date: ${dob}\nCurrent Date: ${now}\n Age  + ${age}");
        // Adds 10 days to your birthdate and prints the resulting date.
        // Task 5: Generic Collections (List and Dictionary) [10 minutes]
        // Creates a List<string> containing the names of 3 of your favorite fruits.
        List<string> fruits = new List<string> { "apple", "banana", "pomegranate" };
        // Adds a new fruit to the list.
        fruits.Add("Mango");
        // Removes one fruit from the list.
        fruits.Remove("banana");
        // Prints all fruits in the list using a foreach loop.
        Console.WriteLine("Fruits:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Creates a Dictionary<int, string> where keys are fruit IDs (1,2,3) and values are the fruit names.
        var fruitDict = new Dictionary<int, string>
        {
            { 1, "apple" },
            { 2, "banana" },
            { 3, "pomegranate" }
        };
        // Adds a new entry to the dictionary and prints all key-value pairs.
        fruitDict.Add(4, "Mango");
        Console.WriteLine("Fruit Dictionary:");
        foreach (var kvp in fruitDict)
        {
            Console.WriteLine($"ID: {kvp.Key}, Fruit: {kvp.Value}");
        }
        // Prints all fruits in the list using a foreach loop.
        // Creates a Dictionary<int, string> where keys are fruit IDs (1,2,3) and values are the fruit names.
        // Adds a new entry to the dictionary and prints all key-value pairs.

    }
}


// Task two Class
class Circle
{
    public const double PI = 3.14;

    public static double AreaOfCirlce(int r)
    {
        return PI * r * r;
    }

    public static double PerimeterOfCircle(int r)
    {
        return 2 * PI * r;
    }
}