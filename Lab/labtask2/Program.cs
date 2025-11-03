using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price = 250;

            Console.Write("Actual price of the product: ");
            Console.WriteLine(price);

            

            Console.Write("Discount price is: ");
            double discount = 250 * 0.15;
            Console.WriteLine(discount);

            Console.Write("Final price is: ");
            Console.WriteLine(price - discount);

        }
    }
}
