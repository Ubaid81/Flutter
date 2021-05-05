using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string choose;
            do
            {

                Console.WriteLine("Enter the Number");
                int num = Convert.ToInt32(Console.ReadLine());
                int result;
                //calculating the square power 
                result = num * num;
                Console.WriteLine("The square power of " + num + " is " + result);
                Console.WriteLine("Do you want to continue? if yes press (y/Y)");
                choose = Console.ReadLine();
            
            } while (choose == "y" || choose == "Y");
        }
    }
}
