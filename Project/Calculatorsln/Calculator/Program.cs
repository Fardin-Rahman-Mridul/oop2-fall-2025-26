// See https://aka.ms/new-console-template for more information
using System;

class Calculator
{
    static void Main()
    {
        bool keepRunning = true;

        do
        {
            
            Console.WriteLine(" Simple Calculator ");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option (1-5): ");
            string choice = Console.ReadLine();

            if (choice == "5")
            {
                keepRunning = false;  
                Console.WriteLine("Goodbye!");
                break;
            }

            
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

           
            switch (choice)
            {
                case "1":
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;

                case "2":
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;

                case "3":
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} x {num2} = {result}");
                    break;

                case "4":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} ÷ {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero!");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose 1–5.");
                    break;
            }

            
            Console.Write("\nDo you want to perform another calculation? (y/n): ");
            string again = Console.ReadLine();
            if (again.ToLower() != "y")
            {
                keepRunning = false;
                Console.WriteLine("Exiting program. Goodbye!");
            }

        } while (keepRunning);
    }
}

