using System;
using AppDevelpment.Week_3;
namespace AppDevelpment
{
    class Program
    {
        static void Main(string[] args)
        {

            // Task 1 Operators 
            Operators operators = new();
            Console.WriteLine($"Addition: ${operators.Add(1, 4)}");
            Console.WriteLine(operators.Subtract(10, 4));
            Console.WriteLine(operators.Multipy(1, 4));
            Console.WriteLine(operators.Divide(10, 4));
            Console.WriteLine(operators.OddEvenFinder(10));


            // Task 2 Null Operations
            NullOperations.PerformNullOperations();


            // Task 3 If Else Switch
            Console.Write("Enter Your Age: ");
            bool mightFailSo = int.TryParse(Console.ReadLine(), out int userAge);
            if (userAge < 13)
            {
                Console.WriteLine("Hello Child");
            }
            else if (userAge < 20)
            {
                Console.WriteLine("Hello Teenager");

            }
            else
            {
                Console.WriteLine("Hello Adult");

            }


            // Task 4 Switch Statement
            Console.Write("Enter a number (1 - 7): ");
            _ = int.TryParse(Console.ReadLine(), out int num);

            switch (num)
            {
                case 1:
                    Console.WriteLine("Day is Sunday");
                    break;
                case 2:
                    Console.WriteLine("Day is Monday");
                    break;
                case 3:
                    Console.WriteLine("Day is Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Day is Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Day is Thursday");
                    break;
                case 6:
                    Console.WriteLine("Day is Friday");
                    break;
                case 7:
                    Console.WriteLine("Day is Saturday");
                    break;

                default:
                    Console.WriteLine("Sike Its a wrong number.");
                    break;
            }

            //    Task 5 Loops
            Console.Write("Enter a number to sum: ");
            _ = int.TryParse(Console.ReadLine(), out int n);

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Sum is: {sum}");


            // Task 6 Try Catch Finally
            // number checker
            try
            {
                Console.WriteLine("Enter a number: ");
                int number = int.Parse(Console.ReadLine() ?? "0");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Number Format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }


            // password strength
            try
            {
                Console.Write("Enter new password: ");
                string? password = Console.ReadLine();

           if (password != null && password.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }

               else if (password != null && password.Length >= 7)
                {
                    Console.WriteLine("Password satistifed the requirement.");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }

        }



    }
}