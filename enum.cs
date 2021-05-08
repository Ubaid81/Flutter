
using System;
namespace enumexample
{
    public class program
    {
        //Declare an emum 
        public enum Month { january, feburary, march, april, may, june, july, august, september, october, november, december };

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter any alphabet/word to find out all the month names that have that alphabet/word.");
            string input = Console.ReadLine();
            string input1 = input.ToLower(); //convert the input string in lower case
            int count = 0;                   //keep a count of total match
            Console.WriteLine("\nThe Month name that have '" + input + "' in the name :\n");
            foreach (Month value in Enum.GetValues(typeof(Month)))      //loop over the value of enum
            {
                string x = value.ToString();        //explicitly convert enum into string and save the string in variable x
                if (x.Contains(input1))
                {
                    Console.WriteLine(char.ToUpper(x[0]) + x.Substring(1));
                    count++;                        //for every match increment the count
                }
            }
            if (count == 0)
            {
                Console.WriteLine("There is no such month name that have '" + input + "' in their name");
            }
        }
    }
} 


