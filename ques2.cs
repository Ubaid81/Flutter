using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student details as per ask\n");
            Console.WriteLine("Enter Name");
            string studentname = Console.ReadLine();
            Console.WriteLine("Enter Roll no.");
            int rollno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Class");
            int classs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter University Name");
            string uniname = Console.ReadLine();

            Console.WriteLine("\nStudent Information\n");

            Console.WriteLine("Name\t\t : " + studentname + "\nRollno\t\t : " + rollno + "\nAge\t\t : " + age);

            if (classs == 1)
            {
                Console.WriteLine("Class\t\t : " + classs +"st");
            }
            else if(classs==2)
            {
                Console.WriteLine("Class\t\t : " + classs +"nd");
            }
            else if(classs==3)
            {
                Console.WriteLine("Class\t\t : " + classs +"rd");
            }
            else
            {
                 Console.WriteLine("Class\t\t : " + classs +"th");
            }
           

            Console.WriteLine("University Name  : " + uniname);

        }
    }
}