using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grade Calculator!");
            while (true)
            {
                Console.Write("Please enter your grade here, should be between 0 and 100: ");
                string input = Console.ReadLine();
                int grade;
                if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
                {
                    string letterGrade = GetLetterGrade(grade);
                    Console.WriteLine($"The corresponding letter grade is: {letterGrade}");

