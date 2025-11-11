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
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double salary = 0f;
            double credit_score = 0f;
            bool criminal_records = false;

            Console.WriteLine("===Mortgage Calculator (Bangladesh)===");

            while (true)
            {
                Console.Write("Enter your monthly salary: ");
                string salaryinput = Console.ReadLine() ?? string.Empty.Trim();
                if(double.TryParse(salaryinput, out salary))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter numerical values.");
                }
                

                
            }

            while (true)
            {
                Console.Write("Enter your credit score (0-500): ");
                string credit_scoreinput = Console.ReadLine() ?? string.Empty.Trim();
                if (double.TryParse(credit_scoreinput, out credit_score))
                {
                    if(credit_score == 0 || credit_score <= 500)
                    
                        break ;
                    

                    else
                    {
                        Console.WriteLine("You are not eligible for the loan");
                    }
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter numerical values.");
                }
            }


            while(true)
            {
                Console.Write("Do you have any criminal record? (true/false): ");
                string criminal_recordsinput = Console.ReadLine() ?? string.Empty.Trim();
                if(bool.TryParse(criminal_recordsinput, out criminal_records))
                {
                    if (criminal_records == true)
                    {
                        Console.WriteLine("You are not eligible for the loan");
                         return;
                    }
                    

                        break;

                }
                else
                {
                    Console.WriteLine("Please, write true or false");
                }
                

               
            }
            
            Console.Write("Enter loan amount: ");
            double loanAmount = Convert.ToDouble(Console.ReadLine());
            while (true)
            {
                if (loanAmount <= 2 * salary)
                {
                    Console.WriteLine("You are elegible for the loan");
                    break;
                }

                else
                {
                    Console.WriteLine("You are not elegible for the loan,because it is more than 2 times than your salary ");
                    return;
                }
                
                
            }
            


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


            
            CultureInfo bdCulture = new CultureInfo("bn-BD");

            Console.WriteLine("\n=== Mortgage Summary ===");

            Console.WriteLine($"\nMonthly Salary: {salary.ToString("C", bdCulture)}");
            Console.WriteLine($"Credit Score: {credit_score.ToString("C", bdCulture)}");
            Console.WriteLine($"Criminal Record: {criminal_records}");
            Console.WriteLine($"Loan Amount: {loanAmount.ToString("C", bdCulture)}");
            Console.WriteLine($"Monthly Payment: {monthlyPayment.ToString("C", bdCulture)}");
            Console.WriteLine($"Total Paid: {totalPaid.ToString("C", bdCulture)}");
            Console.WriteLine($"Total Interest: {totalInterest.ToString("C", bdCulture)}");



        }
    }
}
