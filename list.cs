using System;
using System.Collections.Generic;
using System.Linq;

public class List
{
    public static void Main(string[] args)
    {
        try
        {
         A:
            var flist = new List<int>();        // declare frequency list

            Console.WriteLine("\n");
            Console.WriteLine("Select the kind of list you want to operate on \n");
            Console.WriteLine("Press 1 for Integer List");
            Console.WriteLine("Press 2 for String List");
            Console.Write("\nEnter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("\nEnter total number of element you want to enter in the list");

                int size = Convert.ToInt32(Console.ReadLine());         // Taking size of list from user
                int count;        //keep the count of a particular element in the list
                Console.WriteLine("\nAfter inserting each element press enter key to enter next element.");


                var nlist = new List<int>();        // declare integer list 


                Console.WriteLine("\nEnter the element in the list :\n");
                // read element entered by user
                for (int i = 0; i < size; i++)
                {
                    nlist.Add(Convert.ToInt32(Console.ReadLine()));
                    flist.Add(-1);
                }

                Console.WriteLine("\nEntered element in the list :");
                // display the list entered by user
                for (int i = 0; i < size; i++)
                {
                    Console.Write(nlist[i] + "\t");
                }

                nlist.Sort();       //  sort the list 
                Console.WriteLine("\n");
                Console.WriteLine("\nELEMENT sorted in ascending order :");
                for (int i = 0; i < size; i++)
                {
                    Console.Write(nlist[i] + "\t");
                }

                // check the duplicacy of element
                for (int i = 0; i < size; i++)
                {
                    count = 1;
                    for (int j = i + 1; j < size; j++)
                    {
                        if (nlist[i] == nlist[j])
                        {
                            count++;
                            flist[j] = 0;
                        }
                    }
                    if (flist[i] != 0)
                    {
                        flist[i] = count;
                    }
                }

                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("ELEMENT\t\t\t\t\tFREQUENCY");
                //print requied o/p 
                for (int i = 0; i < size; i++)
                {
                    if (flist[i] != 0)
                    {
                        Console.Write("\n  " + nlist[i] + "\t\t\t\t\t   " + flist[i]);
                    }
                }

                Console.WriteLine("\n");
                Console.WriteLine("\n");
            }

            else if (choice == 2)
            {
                Console.WriteLine("\nEnter total number of element you want to enter in the list");

                int size = Convert.ToInt32(Console.ReadLine());         // Taking size of list from user
                int count;        //keep the count of a particular element in the list
                Console.WriteLine("\nAfter inserting each element press enter key to enter next element.");


                var slist = new List<string>(); //  declare string list


                Console.WriteLine("\nEnter the element in the list :\n");
                //read element entered by user
                for (int i = 0; i < size; i++)
                {
                    slist.Add(Console.ReadLine());
                    flist.Add(-1);
                }           
                // display entered element 
                Console.WriteLine("\nEntered element in the list :");
                for (int i = 0; i < size; i++)
                {
                    Console.Write(slist[i] + "\t");
                }

                slist.Sort();       // sort the list 
                Console.WriteLine("\n");
                Console.WriteLine("\nELEMENT sorted in ascending order :");
                for (int i = 0; i < size; i++)
                {
                    Console.Write(slist[i] + "\t");
                }
                //check for duplicacy
                for (int i = 0; i < size; i++)
                {
                    count = 1;
                    for (int j = i + 1; j < size; j++)
                    {
                        if (slist[i] == slist[j])
                        {
                            count++;
                            flist[j] = 0;
                        }
                    }
                    if (flist[i] != 0)
                    {
                        flist[i] = count;
                    }
                }

                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("ELEMENT\t\t\t\t\tFREQUENCY");
                // print the desire o/p
                for (int i = 0; i < size; i++)
                {
                    if (flist[i] != 0)
                    {
                        Console.Write("\n  " + slist[i] + "\t\t\t\t\t   " + flist[i]);
                    }
                }

                Console.WriteLine("\n");
                Console.WriteLine("\n");
            }

            else
            {
                Console.WriteLine("\nTa Duh! You entered the wrong choice \nTry Again!");
                goto A;
            }

        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}
