using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(10954065) Frank Tei-Deku's Ticket Price Calculator!");

            while (true)
            {
                Console.Write("Please enter your age: ");
                string input = Console.ReadLine();
                int age;

                if (int.TryParse(input, out age) && age >= 0)
                {
                    int ticketPrice = GetTicketPrice(age);
                    Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid age.");
                }

                Console.Write("Would you like to calculate another ticket price? (yes/no): ");
                string continueInput = Console.ReadLine().ToLower();
                if (continueInput != "yes")
                {
                    break;
                }
            }

            Console.WriteLine("Thank you for using (10954065) Frank Tei-Deku's Ticket Price Calculator!");
        }

        static int GetTicketPrice(int age)
        {
            if (age <= 12 || age >= 65)
            {
                return 7;
            }
            else
            {
                return 10;
            }
        }
    }
}