using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(10954065) Frank Tei-Deku's Grade Calculator!");
            while (true)
            {
                Console.Write("Please enter your grade here, should be between 0 and 100: ");
                string input = Console.ReadLine();
                int grade;
                if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
                {
                    string letterGrade = GetLetterGrade(grade);
                    Console.WriteLine($"The corresponding letter grade is: {letterGrade}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                }
                Console.Write("Would you like to enter another grade? (yes/no): ");
                string continueInput = Console.ReadLine().ToLower();
                if (continueInput != "yes")
                {
                    break;
                }
            }
            Console.WriteLine("Thank you for using the Grade Calculator!");
        }
        static string GetLetterGrade(int grade)
        {
            if (grade >= 90)
            {
                return "A";
            }
