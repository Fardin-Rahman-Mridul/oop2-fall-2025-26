using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absClassMember
{
    abstract class Member
    {
        private string name;
        private int memberId;

        public Member(string name, int id)
        {
            this.name = name;
            this.memberId = id;
        }

        public abstract double CalculateFee();
    }

    class StudentMember : Member
    {
        public StudentMember(string name, int id) : base(name, id) { }

        public override double CalculateFee()
        {
            return 300;
        }
    }

    class RegularMember : Member
    {
        public RegularMember(string name , int id) : base(name , id) { }

        public override double CalculateFee()
        {
            return 500;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Member s = new StudentMember("Fardin",3);
            Member r = new RegularMember("Ahad",125);

            Console.WriteLine("Student Fee: " + s. CalculateFee());
            Console.WriteLine("Regular Member Fee: " + r.CalculateFee());
        }
    }
}
