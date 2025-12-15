using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    interface IPrintable
    {
        void Print();
    }

    interface ISerializable
    {
        void Save();
    }

    class Report : IPrintable, ISerializable
    {
        public void Print()
        {
            Console.WriteLine("Printing the document");
        }

        public void Save()
        {
            Console.WriteLine("Saving the document");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Report rep = new Report();
            rep.Print();
            rep.Save();
        }
    }
}
