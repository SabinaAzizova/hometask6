using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Student
    {


        public int Id { get; set; }
        public string Fullname { get; set; }
        public double Point { get; set; }
        public Student(int id, string fullname, double point)
        {
            Id++;
            this.Point = point;
            this.Fullname = fullname;


        }
        public void Showinfo()
        {
            Console.WriteLine($"id:{Id},name:{Fullname},point:{Point}");
        }
        public Student()
        {
            Id++;
        }
    }
}
