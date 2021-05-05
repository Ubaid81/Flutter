using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[50];
            int count =0;
            Console.WriteLine("Enter the number of element you want store in the array");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the element in the array");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.Read());
            }

            for (int i = 0; i < n; i++)
            {
                for(int j = i+1; j<n; j++)
                {
                    if(array[i] == array[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.Write("\nTotal Number of duplicate element : {0} " , count );
            
        }
    }
}






