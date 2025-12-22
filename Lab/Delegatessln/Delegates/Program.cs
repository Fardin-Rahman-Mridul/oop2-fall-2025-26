using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public delegate int Operation(int a, int b);
    class Program
    {
        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }

        static int Multiplication(int x, int y)
        {
            return x * y;
        }

        static int Division(int x, int y)
        {
            return x / y;
        }

        static void Calculate(int a, int b, Operation op)
        {
            int result = op(a, b);
            Console.WriteLine("Result: " + result);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number: ");
            int a  = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");

            Console.Write("Enter choice (1-4): ");
            int choice = int.Parse(Console.ReadLine());

            Operation op = null;

            switch (choice)
            {
                case 1:
                    op = Add;
                    break;
                case 2:
                    op = Subtract;
                    break;
                case 3:
                    op = Multiplication;
                    break;
                case 4:
                    op = Division;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            Calculate (a, b, op);


        }
    }
}
