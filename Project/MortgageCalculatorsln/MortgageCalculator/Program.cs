using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics.Eventing.Reader;

namespace MortgageCalculator
{
    class UserData
    {
        public double Salary { get; set; }
        public double CreditScore { get; set; }
        public bool CriminalRecord { get; set; }
        public double LoanAmount { get; set; }

        public UserData(double salary, double creditScore, bool criminalRecord, double loanAmount)
        {
            Salary = salary;
            CreditScore = creditScore;
            CriminalRecord = criminalRecord;
            LoanAmount = loanAmount;
        }
    }

    class LoanCalculator
    {
        public double AnnualInterestRate { get; set; }
        public int LoanPeriodYears { get; set; }

        public LoanCalculator(double annualRate, int years)
        {
            AnnualInterestRate = annualRate;
            LoanPeriodYears = years;
        }

        public double MonthlyPayment(double loanAmount)
        {
            double monthlyRate = (AnnualInterestRate / 100) / 12;
            int totalMonths = LoanPeriodYears * 12;

            return loanAmount * monthlyRate * Math.Pow(1 + monthlyRate, totalMonths)
                   / (Math.Pow(1 + monthlyRate, totalMonths) - 1);
        }
    }

    class InputManager
    {
        public static double GetDouble(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (double.TryParse(Console.ReadLine(), out double value))
                    return value;

                Console.WriteLine("Invalid input. Enter numbers only!");
            }
        }
        public static bool GetBool(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (bool.TryParse(Console.ReadLine(), out bool value))
                    return value;

                Console.WriteLine("Invalid input. Enter true/false!");
            }
        }
    }
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("=== Mortgage Calculator (Bangladesh) ===");

            double salary = InputManager.GetDouble("Enter your monthly salary: ");
            double creditScore = InputManager.GetDouble("Enter your credit score (0-500): ");

            if (creditScore < 1 || creditScore > 500)
            {
                Console.WriteLine("You are not eligible for the loan.");
                return;
            }

            bool criminalRecord = InputManager.GetBool("Do you have any criminal record? (true/false): ");

            if (criminalRecord)
            {
                Console.WriteLine("You are not eligible for the loan.");
                return;
            }

            double loanAmount = InputManager.GetDouble("Enter loan amount: ");

            if (loanAmount > 2 * salary)
            {
                Console.WriteLine("You are not eligible. Loan exceeds 2 times your salary.");
                return;
            }

            UserData user = new UserData(salary, creditScore, criminalRecord, loanAmount);

            
            double annualRate = InputManager.GetDouble("Enter annual interest rate (%): ");
            int years = (int)InputManager.GetDouble("Enter loan period (years): ");

            LoanCalculator calculator = new LoanCalculator(annualRate, years);
            double monthlyPayment = calculator.MonthlyPayment(user.LoanAmount);

            int totalMonths = years * 12;
            double totalPaid = monthlyPayment * totalMonths;
            double totalInterest = totalPaid - user.LoanAmount;

            CultureInfo bd = new CultureInfo("bn-BD");

            Console.WriteLine("\n=== Mortgage Summary ===");
            Console.WriteLine($"Monthly Salary: {user.Salary.ToString("C", bd)}");
            Console.WriteLine($"Credit Score: {user.CreditScore}");
            Console.WriteLine($"Criminal Record: {user.CriminalRecord}");
            Console.WriteLine($"Loan Amount: {user.LoanAmount.ToString("C", bd)}");
            Console.WriteLine($"Monthly Payment: {monthlyPayment.ToString("C", bd)}");
            Console.WriteLine($"Total Paid: {totalPaid.ToString("C", bd)}");
            Console.WriteLine($"Total Interest: {totalInterest.ToString("C", bd)}");

        }
    }
}
