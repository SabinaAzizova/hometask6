using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Group
    {


        Student[] students;
        public string Groupno { get; set; }
        private int studentlimit;
        public int Studentlimit
        {
            get
            {
                return studentlimit;
            }
            set
            {
                if (value >= 5 && value <= 18)
                {
                    studentlimit = value;
                }
            }
        }
        public Group(int studentlimit)
        {

            Studentlimit = studentlimit;
        }
        public Group()
        {
            students = new Student[0];
        }
        public void Addstudent(Student student)
        {
            if (studentlimit < students.Length)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;

            }
            else
            {
                Console.WriteLine("limit doldu");
            }
        }

        public bool Checkgroupno(string groupno)
        {
            bool uppercharacter1 = false;
            bool uppercharacter2 = false;
            bool number1 = false;
            bool number2 = false;
            bool number3 = false;
            if (groupno.Length < 5)
            {
                return false;
            }
            foreach (var character in groupno)
            {
                if (char.IsUpper(groupno[0]))
                {
                    uppercharacter1 = true;
                    continue;
                }
                if (char.IsUpper(groupno[1]))
                {
                    uppercharacter2 = true;
                    continue;
                }
                if (char.IsDigit(groupno[2]))
                {
                    number1 = true;
                    continue;
                }
                if (char.IsDigit(groupno[3]))
                {
                    number2 = true;
                    continue;
                }
                if (char.IsDigit(groupno[4]))
                {
                    number3 = true;
                    break;
                }



            }
            return uppercharacter1 && uppercharacter2 && number1 && number2 && number3;
        }
        public void Getallgroup()
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

        }
        public Group[] Getid(int id)
        {
            Group[] groups = new Group[0];
            foreach (var group in groups)
            {
                if (id == Student.Id)
                {
                    Array.Resize(ref groups, groups.Length + 1);
                    groups[groups.Length - 1] = group;
                }
            }
            return groups;

        }
    }
}
