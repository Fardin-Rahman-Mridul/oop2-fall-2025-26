using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Student number: ");
            int firstnumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Student number: ");
            int secondnumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Third Student number: ");
            int thirdnumber = Convert.ToInt32(Console.ReadLine());



            double calculate_average = Convert.ToDouble(firstnumber + secondnumber + thirdnumber) / 3;

            Console.WriteLine($"Average score of 3 student is: = {calculate_average:F2}");


        }
    }
}
