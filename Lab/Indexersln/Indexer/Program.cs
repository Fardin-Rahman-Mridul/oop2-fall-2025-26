using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordSystem
{
    interface IStudent
    {
        void DisplayInfo();
    }

    class Student : IStudent
    {
        private string name;
        private int[] scores = new int[3];

        public Student(string name)
        {
            this.name = name;
        }

        public int this[int index]
        {
            get { return scores[index]; }
            set { scores[index] = value; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Student Name: " + name);
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("Score " + (i + 1) + ":" + scores[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student("JAMIL");

            stu[0] = 89;
            stu[1] = 95;
            stu[2] = 81;

            stu.DisplayInfo();
        }
    }
}