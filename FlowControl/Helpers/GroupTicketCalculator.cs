using FlowControl.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl.Helpers
{
    public class GroupTicketCalculator
    {
        public static void CalcGroupTicket()
        {
            Console.Write("Enter the number of people in the group: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int numOfGruop) && numOfGruop > 0)
            {
                int totalPrice = 0;

                for (int i = 0; i < numOfGruop; i++)
                {
                    Console.Write($"Enter age for person {i + 1}: ");
                    string ageInput = Console.ReadLine();

                    if (int.TryParse(ageInput, out int age) && age > 0)
                    {
                        TicketType ticketType = SingleTicketCalculator.GetTicketType(age);
                        int price = SingleTicketCalculator.GetPrice(ticketType);
                        totalPrice += price;
                        Console.WriteLine($"Person {i + 1} is a {ticketType}, ticket costs {price} kr.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Skipping this person.");
                    }
                }

                Console.WriteLine($"Total price for the group: {totalPrice} kr.");
            }
            else
            {
                Console.WriteLine("Invalid input of the number of group.");
            }
        }
    }
}
