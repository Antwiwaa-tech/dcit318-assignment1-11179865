using System;
namespace TicketPriceCalculatorApp
{
    class TicketPriceClac
    {
        static void Main(String[] args)
        {
            Console.Write("Get Your Tickets Here\nEnter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.ReadLine();

            int ticketPrice = 10;

            if (age <= 12 || age >= 65 )
            {
                Console.WriteLine("You get a discount\nYour price is 7 cedis");
            }
            else
            {
                Console.WriteLine($"Movie ticket is {ticketPrice} cedis");
            }
        }
    }
}