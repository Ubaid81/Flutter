using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Base length of the triangle");
        double baselength = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the height");
        double height = Convert.ToDouble(Console.ReadLine());

        double area = (baselength * height) / 2;
        Console.WriteLine("Area of Triangle : "+area);
    }
}