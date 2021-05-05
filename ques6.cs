using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\tLibrary Management System\t\t\t\t\n\n");
            A:
            Console.WriteLine("Select from the given options");
            Console.WriteLine("c : for computer books");
            Console.WriteLine("m : for mathematical books");
            Console.WriteLine("h : for history books");
            Console.WriteLine("e : for English books");

            string choose = Console.ReadLine();


            switch (choose)
            {
                case "c":
                    Console.WriteLine("Computer books are available");
                    break;
                case "m":
                    Console.WriteLine("Mathematical books are available");
                    break;
                case "h":
                    Console.WriteLine("History books are unavailable");
                    break;
                case "e":
                    Console.WriteLine("English books are available");
                    break;
                default:
                    Console.WriteLine("Try Again");
                    goto A;
            }




        }
    }
}


