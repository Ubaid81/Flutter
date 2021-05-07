//Write a program for creating a Car in which Engine, Tyre, Sound System should be defined in a base class.
//Your program should inherit all the functionality and gives custom color to a car using interface
//


using System;

namespace Test
{
    class Car
    {
       public string Engine = "ax 2030";
       public string Tyre = "MRF double Coated Rubber Tubeless";
       public string SoundSystem = "2 doubly Speaker";

    }

    interface IColour
    {
        string customColour();
    }

    class CarVarient : Car , IColour 
    {
        public string customColour()
        {
            Console.WriteLine("Enter Colour name that you want for your car");
            string col = Console.ReadLine();
            return col;
        }
    }

    class Program 
    {
        static void Main(string[] args)
        {
            CarVarient obj = new CarVarient();
            string a = obj.Engine;
            string b = obj.Tyre;
            string c = obj.SoundSystem;
            string d = obj.customColour();

            Console.WriteLine("\n\tENGINE : " + a + "\n\tTYRE : " + b + "\n\tSOUNDSYSTEM : " + c + "\n\tCOLOUR : " + d); 
        }
    }
}