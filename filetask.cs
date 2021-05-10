

// WAP to create and read the last n number of lines of a file.


using System;
using System.IO;  // include the System.IO namespace

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would You like to Choose the existing file ? if yes , press 1 ");
            string choice = Console.ReadLine();
            int count = 0;
            if(choice == "1")           // for working on the exsisting file in the system
            {
                Console.WriteLine("Enter File name (if not know then check in the directory given as name followed by .txt extention): ");
                string fileName = Console.ReadLine();
                Console.WriteLine("\n\n");
                if (File.Exists(fileName))
                {
                    using (StreamReader sr = File.OpenText(fileName))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)             //check end of line 
                        {
                            count++;                                // increment count we get a line 
                        }
                    }
                    Console.WriteLine("Input how many last numbers of lines you want to display ");
                    int last = Convert.ToInt32(Console.ReadLine());
                    if (last >= 1 && last <= count)
                    {
                        Console.WriteLine("The content of the last {0} lines of the file {1} is : \n", last, fileName);
                        for (int i = count - last; i < count; i++)
                            {
                                string[] lines = File.ReadAllLines(fileName);
                                Console.Write( lines[i] );
                            }
                    }
                }
                else
                {
                    Console.WriteLine("No such name file found in the directory");

                    Console.WriteLine("\n\n#RUN_AGAIN\n\n");
                }
            }
            else
            {
                Console.WriteLine("OKAY! Let's create a new file\n");

                string fileName =  "demo.txt";
                string[] Lines;

                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                Console.WriteLine("Input number of lines to write in the file  : ");
                int n = Convert.ToInt32(Console.ReadLine());
                Lines = new string[n];
                Console.WriteLine("\nInput {0} strings below :\n", n);
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Input line {0} : ", i + 1);
                    Lines[i] = Console.ReadLine();
                }
                System.IO.File.WriteAllLines(fileName, Lines);

                Console.WriteLine("\n");

                Console.WriteLine("Input last how many numbers of lines you want to display ");
                int last = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n");

                if (last >= 1 && last <= n)
                {
                    Console.WriteLine("The content of the last {0} lines of the file {1} is : \n", last, fileName);
                    for (int i = n - last; i < n ; i++)
                    {
                        string[] lines = File.ReadAllLines(fileName);
                        Console.WriteLine(lines[i]);
                    }
                }

                Console.WriteLine("\n");
                Console.WriteLine("\n");

            }
        }
    }
}