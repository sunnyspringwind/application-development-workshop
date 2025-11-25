using System;
using AppDev.Week_5;
namespace AppDev
{
    class Program
    {
        static void Main(string[] args)
        {


            // Task 1: Encapsulation
            Console.WriteLine("Task 1: Encapsulation");
            BankAccount account1 = new BankAccount("ACC7100");

            //priting account number, deposit and withdraw
            Console.WriteLine(account1.AccountNumber);
            Console.WriteLine(account1.Deposit(20000));
            Console.WriteLine(account1.Withdraw(300000));


            // Task 2: Inheritance
            Console.WriteLine("Task 2: Inheritance");
            Car car = new Car(6);
            car.Brand = "BMW";
            car.Speed = 40;
            car.DisplayInfo();
            Console.WriteLine();
            Motorcycle motorcycle = new Motorcycle("red");
            motorcycle.Brand = "Honda";
            motorcycle.Speed = 60;
            motorcycle.DisplayInfo();


            // Task 3: Polymorphism
            // Vechicle class 
            Console.WriteLine("Task 3: Polymorphism");

            Printer printer = new Printer();
            printer.Print("Calling all autobots.");
            printer.Print(123);
            printer.Print("Calling all autobots", 123);

            // Teacher class
            Console.WriteLine();
            Console.WriteLine("English Teacher");
            EnglishTeacher teacher1 = new EnglishTeacher();
            teacher1.Teaching();
            teacher1.SalaryInfo();

            Console.WriteLine("Nepali Teacher");
            NepaliTeacher teacher2 = new NepaliTeacher();
            teacher2.Teaching();
            teacher2.SalaryInfo();


            // Task 4: Abstraction
            Console.WriteLine();
            Console.WriteLine("Task 4: Abstraction");
            Console.WriteLine("Abstract Car:");
            AppDev.Week_5.Abstract.Car car2 = new AppDev.Week_5.Abstract.Car();
            car2.StartEngine();
            car2.StopEngine();
            car2.Display();
            Console.WriteLine();

            
            Console.WriteLine("Abstract Bike:");
            AppDev.Week_5.Abstract.Bike bike = new AppDev.Week_5.Abstract.Bike();
            bike.StartEngine();
            bike.StopEngine();
            bike.Display();

            // Task 5 : OOP
            Console.WriteLine();
            Console.WriteLine("Task 5 : OOP");
            // ElectronicsStore object
            ElectronicsStore store = new ElectronicsStore();

            // Laptop and Smartphone objects
            Laptop myLaptop = new Laptop("Dell", 1200);
            Smartphone myPhone = new Smartphone("Samsung", 800);

            // Add to the store
            store.AddDevice(myLaptop);
            store.AddDevice(myPhone);

            // Display all devices info including child-specific behavior
            store.ShowAllDeviceDetails();

        }

    }

}