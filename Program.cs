using System;
using System.Security.Cryptography.X509Certificates;
using AppDev.Week_6;
using AppDevWeek_6;
namespace AppDev
{
    class Program
    {
        static void Main(string[] args)
        {


            // Task 1: Encapsulation
            Console.WriteLine("Task 1: Expression Bodied Members");
            Rectangle rect = new Rectangle();

            //priting are and rect
            Console.WriteLine(rect.GetArea());
            Console.WriteLine(rect.CalculatePerimenter());
            Console.WriteLine();


            // Task 2: Custom Deligate
            Console.WriteLine("Task 2: Custom Delegates");
            // delelgate initialization
            Calculate cal;
            // Addition
            cal = DelegateExample.Add;
            Console.WriteLine($"Sum: {cal(2, 3)}");

            // Subtraction
            cal = DelegateExample.Subtract;
            Console.WriteLine($"Subtract: {cal(3, 2)}");

            // Discount Strategy [Festive, Seasonal, No Discount]
            Console.WriteLine("Discount Strategy");
            DelegateExample.DiscoutStrategy discount;
            double price = 1000;

            discount = DelegateExample.FestiveDiscout;
            Console.WriteLine($"Festive Discount: {discount(price)}");
            discount = DelegateExample.SeasonalDiscout;
            Console.WriteLine($"Seasional Discount: {discount(price)}");
            discount = DelegateExample.NoDiscout;
            Console.WriteLine($"No Discount: {discount(price)}");

            // final price calculation [using delegate as arguments]
            Console.WriteLine("Final Price Calculation");
            Console.WriteLine(DelegateExample.CalculateFinalPrice(price, DelegateExample.FestiveDiscout));
            Console.WriteLine(DelegateExample.CalculateFinalPrice(price, DelegateExample.SeasonalDiscout));
            Console.WriteLine(DelegateExample.CalculateFinalPrice(price, DelegateExample.NoDiscout));
            Console.WriteLine($"Using Lambda: {DelegateExample.CalculateFinalPrice(price, (price) => price * 0.7)}");
            Console.WriteLine();

            // // Task 3: Built-in Delegate 
            Console.WriteLine("Task 3: Built-in Delegate ");
            void ProcessNumber(int[] numbers, Func<int, bool> condition)
            {
                numbers.Where(condition).ToList().ForEach(Console.WriteLine);

            }

            int[] numbers = [1, 4, 8, 11, 12, 13, 14];
            Console.WriteLine("Numbers greater then 10: ");
            ProcessNumber(numbers, n => n > 10);
            Console.WriteLine();
            Console.WriteLine("Even Numbers: ");
            ProcessNumber(numbers, n => n % 2 == 0);
            Console.WriteLine();


            // Task 4: LINQ Basics
            Console.WriteLine("LINQ BASICS");
            int[] integers = [1, 2, 3, 4, 5];
            // Selecting 
            integers.Select(n => n * 2).ToList().ForEach(Console.WriteLine);

            // Filtering(Where)
            Book book1 = new("To kill a mockingbird", 2000);
            Book book2 = new("The Stranger", 900);
            Book book3 = new("Norwegian Wood", 1300);
            Book book4 = new("1984", 800);
            Book book5 = new("Ramayana", 2100);

            Book[] books = [book1, book2, book3, book4, book5];

            // creating book list and filtering books priced above 1000
            List<Book> premiumBooks = [.. books.Where(book => book.Price > 1000)];
            Console.WriteLine("Premium Books: ");
            premiumBooks.Select(book => $"Title: {book.Title} || Price: {book.Price}").ToList().ForEach(Console.WriteLine);

            //  Sorting  
            List<Student> students = [
            new Student("Scout Finch", "Forensic Anthropology", 92),
            new Student("Holden Caulfield", "Psychology", 88),
            new Student("Toru Watanabe", "Philosophy", 90),
            new Student("Lyra Belacqua", "Astrophysics", 95),
            new Student("Ender Wiggin", "Game Theory", 97),
            new Student("Frodo Baggins", "Environmental Science", 85),
            new Student("Arya Stark", "Martial Arts & Strategy", 93),
            new Student("Atticus Finch", "Law", 98),
            new Student("Hermione Granger", "Magical Law & Ethics", 99),
            new Student("Jay Gatsby", "Business & Economics", 87)
        ];
            List<Student> sortedStudents = [.. students.OrderBy(s => s.Name)];

            // order by ascending
            Console.WriteLine("Order by Acending: ");
            foreach (Student s in sortedStudents)
            {
                Console.WriteLine($"Name: {s.Name} || Major: {s.Major}");
            }

            Console.WriteLine();
            // order by descending
            List<Student> descSortedStudents = [.. students.OrderByDescending(s => s.Name)];
            Console.WriteLine("Order by Descending: ");
            foreach (Student s in descSortedStudents)
            {
                Console.WriteLine($"Name: {s.Name} || Major: {s.Major}");
            }


            var salesList = new List<CashierSales>
        {
            new CashierSales { CashierName = "Alice", Sales = 1200.50m },
            new CashierSales { CashierName = "Bob", Sales = 950.75m },
            new CashierSales { CashierName = "Charlie", Sales = 1450.00m },
            new CashierSales { CashierName = "Diana", Sales = 800.25m }
        };


            // Task 5

            // Task 5.1
            // Total number of cashiers
            int totalCashiers = salesList.Count();

            // Total sales
            decimal totalSales = salesList.Sum(c => c.Sales);

            // Highest, lowest, average sales
            decimal highest = salesList.Max(c => c.Sales);
            decimal lowest = salesList.Min(c => c.Sales);
            double average = (double)salesList.Average(c => c.Sales);

            Console.WriteLine($"Total Cashiers: {totalCashiers}");
            Console.WriteLine($"Total Sales: {totalSales}");
            Console.WriteLine($"Highest Sale: {highest}");
            Console.WriteLine($"Lowest Sale: {lowest}");
            Console.WriteLine($"Average Sale: {average:F2}");

            // Task 5.2
            var applicants = new List<Applicant>
        {
            new Applicant { Name = "Alice", Age = 20 },
            new Applicant { Name = "Bob", Age = 17 },
            new Applicant { Name = "Charlie", Age = 19 },
            new Applicant { Name = "Diana", Age = 16 }
        };

            // Are there any applicants under 18?
            bool anyUnder18 = applicants.Any(a => a.Age < 18);

            // Are all applicants above 16?
            bool allAbove16 = applicants.All(a => a.Age > 16);

            Console.WriteLine($"Any under 18? {anyUnder18}");
            Console.WriteLine($"All above 16? {allAbove16}");

            var songs = new List<Song>
        {
            new Song { Title = "Song A", DurationSeconds = 180 },
            new Song { Title = "Song B", DurationSeconds = 250 },
            new Song { Title = "Song C", DurationSeconds = 300 },
            new Song { Title = "Song D", DurationSeconds = 700 }
        };

            // Task 5.3
            // First and last song
            var firstSong = songs.First();
            var lastSong = songs.Last();

            // First song longer than 4 minutes (240 sec)
            var firstAbove4Min = songs.First(s => s.DurationSeconds > 240);

            // Safe result for first song longer than 10 minutes (600 sec)
            var firstAbove10Min = songs.FirstOrDefault(s => s.DurationSeconds > 600);

            Console.WriteLine($"First Song: {firstSong.Title}");
            Console.WriteLine($"Last Song: {lastSong.Title}");
            Console.WriteLine($"First Song >4 min: {firstAbove4Min.Title}");
            Console.WriteLine($"First Song >10 min: {(firstAbove10Min != null ? firstAbove10Min.Title : "None")}");
            Console.WriteLine();


            // Task 6: LINQ Continued

            var bookings = new List<Booking>
            {
                new() { CustomerName = "Aases", Destination = "Pokhara", Price = 8000, DurationInDays = 3, IsInternational = false },
                new() { CustomerName = "Prija", Destination = "Thailand", Price = 15000, DurationInDays = 5, IsInternational = true },
                new() { CustomerName = "Aleesa", Destination = "Chitwan", Price = 12000, DurationInDays = 6, IsInternational = false },
                new() { CustomerName = "Leesa", Destination = "Singapore", Price = 20000, DurationInDays = 4, IsInternational = true },
                new() { CustomerName = "Parash", Destination = "Pokhara", Price = 11000, DurationInDays = 5, IsInternational = false }
            };

            // Filter and transform
            var report = bookings
        // Filter: price > 10000 AND duration > 4
        .Where(b => b.Price > 10000 && b.DurationInDays > 4)

        // Transform into anonymous object with Category
        .Select(b => new
        {
            b.CustomerName,
            b.Destination,
            Category = b.IsInternational ? "International" : "Domestic",
            b.Price
        })

        // Sort: Domestic first, then International, then by Price ascending
        .OrderBy(b => b.Category)        // "Domestic" comes before "International"
        .ThenBy(b => b.Price)
        .ToList();

            // display in clear format
            foreach (var b in report)
            {
                Console.WriteLine($"Customer: {b.CustomerName}");
                Console.WriteLine($"Destination: {b.Destination}");
                Console.WriteLine($"Category: {b.Category}");
                Console.WriteLine($"Price: Rs. {b.Price}");
                Console.WriteLine(new string('-', 30));
            }

        }


    }

}