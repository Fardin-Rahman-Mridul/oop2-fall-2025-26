using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseExercise
{
    public class House
    {
        public int YearBuilt {  get;  private set; }
        public double Size { get; private set; }

        public House(int yearbuilt, double size)
        {
            YearBuilt = yearbuilt;
            Size = size;
        }

        private int HowOld()
        {
            int CurrentYear = DateTime.Now.Year;
            return CurrentYear - YearBuilt;
        }

        public bool CanBeSold()
        {
            return HowOld() > 15;
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the year the house was built: ");
            int yearBuilt = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the size of the house (e.g. in sq ft): ");
            double size = Convert.ToDouble(Console.ReadLine());

            
            House userHouse = new House(yearBuilt, size);

            
            Console.WriteLine("\n--- House Information ---");
            Console.WriteLine("Year Built: " + userHouse.YearBuilt);
            Console.WriteLine("Size: " + userHouse.Size + " sq ft");
            Console.WriteLine("Can be sold: " + userHouse.CanBeSold());
        }
    }
}
