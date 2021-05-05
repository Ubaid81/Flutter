using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Base Number");
            int basenum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Exponent Number");
            int expo = Convert.ToInt32(Console.ReadLine());
            int result = 1, temp = expo;
            //calculating the power 
            while(temp!=0)
            {
                result *= basenum;
                temp--;
            }

            Console.WriteLine("The result of power("+basenum+","+expo+") is "+ result);
        }
    }
}
