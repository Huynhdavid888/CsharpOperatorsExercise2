using System;

namespace CSharpOperatorExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What is the radius of your circle?");
           
            var radius = double.Parse(Console.ReadLine());

            var r = 30;
            var pi = Math.PI;
            var areaOfCircle = Math.PI * (radius * radius);
            Console.WriteLine($"The area of a circle with radius {r} is {areaOfCircle}");
        }
    }
}
