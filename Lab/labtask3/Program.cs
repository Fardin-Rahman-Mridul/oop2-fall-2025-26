using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace labtask3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insert temp in C = ");
            double Celsius = double.Parse(Console.ReadLine());

            double Fahrenheit = (Celsius * 9 / 5) + 32;

            Console.WriteLine($"Temperature in F = {Fahrenheit:F2}");




        }
    }
}
