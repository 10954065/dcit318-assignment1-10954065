using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(10954065) Frank Tei-Deku'sTriangle Type Identifier!");

            while (true)
            {
                Console.Write("Enter the length of side 1: ");
                string input1 = Console.ReadLine();
                Console.Write("Enter the length of side 2: ");
                string input2 = Console.ReadLine();
                Console.Write("Enter the length of side 3: ");
                string input3 = Console.ReadLine();

                double side1, side2, side3;

                if (double.TryParse(input1, out side1) && double.TryParse(input2, out side2) && double.TryParse(input3, out side3))
                {
                    string triangleType = GetTriangleType(side1, side2, side3);
                    Console.WriteLine($"The triangle is: {triangleType}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter valid numbers for the sides.");
                }

                Console.Write("Would you like to identify another triangle? (yes/no): ");
                string continueInput = Console.ReadLine().ToLower();
                if (continueInput != "yes")
                {
                    break;
                }
            }

            Console.WriteLine("Thank you for using (10954065) Frank Tei-Deku's Triangle Type Identifier!");
        }

        static string GetTriangleType(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }
}