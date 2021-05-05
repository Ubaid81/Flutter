using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] main_array = new int[50];
            int[] odd_array = new int[50];
            int[] even_array = new int[50];
            int j = 0, k = 0;
            Console.WriteLine("Enter the number of element you want store in the array");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the element in the array");
            for (int i = 0; i < n; i++)
            {
                main_array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (main_array[i] % 2 == 0)
                {
                    even_array[j] = main_array[i];
                    j++;
                }
                else
                {
                    odd_array[k] = main_array[i];
                    k++;
                }
            }

            Console.Write("\nThe even integer element are :");
            for (int i = 0; i < j; i++)
            {
                Console.Write("{0} ", even_array[i]);
            }
            Console.Write("\nThe Odd integer element are :");
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ", odd_array[i]);
            }
        }
    }
}






