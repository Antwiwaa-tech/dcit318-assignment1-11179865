using System;

namespace TriangleTypeIdentifier
{
    class Triangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's determine the triangle type");

            Console.Write("Side 1: ");
            int side1 = int.Parse(Console.ReadLine());

            Console.Write("Side 2: ");
            int side2 = int.Parse(Console.ReadLine());

            Console.Write("Side 3: ");
            int side3 = int.Parse(Console.ReadLine());

            // Check if valid triangle first
            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("The triangle is Equilateral.");
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    Console.WriteLine("The triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is Scalene.");
                }
            }
            else
            {
                Console.WriteLine("The values do not form a valid triangle.");
            }
        }
    }
}
