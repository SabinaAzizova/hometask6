using System.Text.RegularExpressions;
using ConsoleApp7;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)  //muellim xesteyem errorlara baxa bilmedim uzurlu sayin <3
        {
            bool exit = false;
            Group group = new Group();

            do
            {
                Console.WriteLine("Welcomee.");
                Console.WriteLine("Menu");
                Console.WriteLine("1.Show Info");
                Console.WriteLine("2.Create New Group");
                Console.WriteLine("0.Quit");
                Console.WriteLine("Enter your Choice");
                string input = Console.ReadLine();

                switch (input)

                {
                    case "1":
                        Student student = createstudent();
                        student.StudentInfo();
                        break;


                    case "2":
                        Group group1 = new Group();
                        break;
                    default:
                        Console.WriteLine("dogru ishlemir");
                    case "3":

                        break;
                        bool exit2 = true;
                        do {

                        
            } while (exit2 != false) ;
            }
    }while(exit!=true);
        {
        public static Student createstudent()
    }
    Student user = new Student(Student);
    Console.WriteLine("Enter user's details:"); ;
Console.WriteLine("Enter user's Id:");
ConvertToInt32(console.Readline());
    Console.WriteLine("Enter user's Fullname");
Convert.ToString(Console.ReadLine());
Console.WriteLine("Enter user's Point");
Convert.ToDouble(Console.ReadLine());
return user;

            }
        }
    }
}

