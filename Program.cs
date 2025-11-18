using System;
using AppDev.Week_4;

namespace AppDev
{
    class Program
    {
        static void Main(string[] args)
        {


    // Task 1: Class, Object & Fields
            Student student1 = new()
            {
                Id = 1,
                Name = "Ashish",
                Description = "Definately Looks like Henry Cavil"
            };

            Student student2 = new()
            {
                Id = 2,
                Name = "Sidney",
                Description = "Looks like a girl"
            };

            // printing instance values
            Console.WriteLine($"ID: {student1.Id} | Name: {student1.Name} | Desc: {student1.Description}");
            Console.WriteLine($"ID: {student2.Id} | Name: {student2.Name} | Desc: {student2.Description}");

            // printing static values
            Console.WriteLine($"School: {Student.School}");


    // Task 2: Methods & Return Types
            // Create an object of Calculator
            Calculator calc = new();

            // Call void method
            calc.PrintWelcome();

            // Call Add method and print the result
            int sum = calc.Add(5, 10);
            Console.WriteLine("Sum: " + sum);

            // Call Multiply method with both parameters
            int product1 = calc.Multiply(5, 3);
            Console.WriteLine("Product (5 * 3): " + product1);

            // Call Multiply method with only first parameter (num2 defaults to 1)
            int product2 = calc.Multiply(7);
            Console.WriteLine("Product (7 * default 1): " + product2);


    // Task 3 : Parameter Types 
        ParameterDemo demo = new ParameterDemo();

        // 1. Using ref
        int myNumber = 5;
        demo.Increase(ref myNumber);
        Console.WriteLine("Number after Increase: " + myNumber);

        // 2. Using out
        demo.GetFullName(out string fullName);
        Console.WriteLine("Full Name: " + fullName);

        // 3. Using params
        int sum1 = demo.SumAll(2, 4, 6, 8);
        Console.WriteLine("Sum of all numbers: " + sum1);


    // Task 4 : Constructors
        // 1. Create object using default constructor
        Player defaultPlayer = new Player();

        // Since default constructor does not set values, set manually for display maybe.
        defaultPlayer.playerName = "DefaultHero";
        defaultPlayer.level = 1;
        defaultPlayer.health = 100;

        // Print default player values
        Console.WriteLine($"Default Player: Name = {defaultPlayer.playerName}, Level = {defaultPlayer.level}, Health = {defaultPlayer.health}");

        // 2. Create object using parameterized constructor
        Player paramPlayer = new Player("Ashish", 5, 150);

        // Print parameterized player values
        Console.WriteLine($"Parameterized Player: Name = {paramPlayer.playerName}, Level = {paramPlayer.level}, Health = {paramPlayer.health}");
 

    // Task 5 : Enums and Records

        // --- Enum Tasks ---

       // Ask user to input a day
        Console.Write("Enter a day: ");
        string? dayInput = Console.ReadLine();

        // Determine if Weekend or Weekday
        DayType dayType;

        if (dayInput.Equals("Friday", StringComparison.OrdinalIgnoreCase) ||
            dayInput.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
        {
            dayType = DayType.Weekend;
        }
        else
        {
            dayType = DayType.Weekday;
        }

        Console.WriteLine($"It is: {dayType}");

        // --- Record Tasks ---

        // Create a Book record
        Book book1 = new Book("C# Basics", "John Doe", 499.99);

        // Create another book using 'with' expression
        Book book2 = book1 with { title = "Advanced C#", price = 599.99 };

        // Printing first book object
        Console.WriteLine($"Modified Book: {book1.title}, {book1.author}, {book1.price}");


    // Task 6: Debugging

        Console.Write("Enter marks: ");
        bool isValidMarks = int.TryParse(Console.ReadLine(), out int marks);

        Console.Write("Enter total: ");
        bool isValidTotal = int.TryParse(Console.ReadLine(), out int total);

        double percentage = marks / total * 100;
        // double percentage = (double)marks / total * 100; correct approach

        Console.WriteLine("Percentage: " + percentage);
        //  C# does integer division first, e.g 45 / 50 = 0 → then 0 * 100 = 0 thus should Convert one operand to double before division:
        }

    }

}