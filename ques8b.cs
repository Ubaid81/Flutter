using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5, t = n, j;
            for (int i = 1; i <= n; i++)
            {
                for (j = 1; j <= t - 1; j++)   //generate space
                    Console.Write(" ");
                for (j = 1; j <= i; j++)       //print digit in ascending order upto i 
                    Console.Write(j);
                for (j = i - 1; j >= 1; j--)   //print digit in decending order from i to 1
                    Console.Write(j);
                Console.Write("\n");
                t--;
            }
            for(int i = 1; i<=n-1; i++)
            {
                for (j = 1; j <= i; j++)           //generate space
                    Console.Write(" ");
                for (j = 1; j <= n - i; j++)       //print digit in ascending order upto (n-i)
                    Console.Write(j);
                for (j = n - (i+1); j >= 1; j--)   //print digit in decending order upto 1
                    Console.Write(j);
                Console.Write("\n");
               
            }
        }
    }
}
