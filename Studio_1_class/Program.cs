using System;

namespace Studio_1_class
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a radius: ");
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            double diameter = 2 * radius;
            double circumference = Math.PI * diameter;
            Console.WriteLine("The area of a circle of radius " + radius + " is: " + area);
            Console.WriteLine("The diameter of a circle of radius " + radius + "is:" + diameter);
            Console.WriteLine("The circumference of a circle of radius " + radius + " is: " + circumference);

            Console.WriteLine("Enter how many Miles per Gallon for your car: ");
            double mpg = double.Parse(Console.ReadLine());

            double numOfGallonsNeeded = circumference / mpg;
            Console.WriteLine("You will need " + numOfGallonsNeeded + "to drive the circumference of this circle.");

        }
    }
}
