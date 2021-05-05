using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your City");
            string usercity = Console.ReadLine();
            Console.WriteLine("Enter your Street");
            string userstreet = Console.ReadLine();
            Console.WriteLine("Enter your Pin");
            int userpin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your House no.");
            int userhno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Address: " + username + "\n\t " + userhno + "," + userstreet + "\n\t " + usercity + "-" + userpin);



        }
    }
}