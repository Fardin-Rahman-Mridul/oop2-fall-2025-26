using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absClassPayment
{
    abstract class Payment
    {
        public abstract void ProcessPayment(double amount);
    }

    class BkashPayment : Payment
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine("Processing Bkash Payment: " + amount);
        }
    }

    class CreditCardPayment : Payment
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine("Processing Credit Card Payment: " + amount);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Payment p1 = new BkashPayment();
            Payment p2 = new CreditCardPayment();

            p1.ProcessPayment(500);
            p2.ProcessPayment(5000);
        }
    }
}
