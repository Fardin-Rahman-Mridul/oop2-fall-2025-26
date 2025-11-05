using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Mortgage Calculator (Bangladesh) ===");

            
            Console.Write("Enter loan amount: ");
            double loanAmount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter annual interest rate (in %): ");
            double annualInterestRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter loan period (in years): ");
            int loanPeriodYears = Convert.ToInt32(Console.ReadLine());

            
            double monthlyInterestRate = (annualInterestRate / 100) / 12;

           
            int totalMonths = loanPeriodYears * 12;

            
            double monthlyPayment = loanAmount * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, totalMonths)
                                    / (Math.Pow(1 + monthlyInterestRate, totalMonths) - 1);

            
            double totalPaid = monthlyPayment * totalMonths;
            double totalInterest = totalPaid - loanAmount;

            
            Console.WriteLine();
            Console.WriteLine($"Monthly Payment: {monthlyPayment: 0.00}$");
            Console.WriteLine($"Total Paid: {totalPaid: 0.00}$");
            Console.WriteLine($"Total Interest: {totalInterest: 0.00}$");



        }
    }
}
