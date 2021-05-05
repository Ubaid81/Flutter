using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the total money you have");
        int money = Convert.ToInt32(Console.ReadLine());
        double tax;
        if (money<10000)
        {
            tax = money * 0.05;  //5% tax
            Console.WriteLine("Total Tax : " + tax );
        }
        else if (money<=10000 || money>=100000)
        {
            tax = money * 0.08;  //8% tax
            Console.WriteLine("Total Tax : " + tax);
        }
        else
        {
            tax = money * 0.085;  //8.5% tax
            Console.WriteLine("Total Tax : " + tax);
        }

    }
}