using FlowControl.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl.Helpers
{
    public class TicketHelper
    {
        public class SingleTicketCalculator
        {
            public static TicketType GetTicketType(int age)
            {
                if (age < 5)
                    return TicketType.Child;

                else if (age < 20)
                    return TicketType.Youth;

                else if (age > 100)
                    return TicketType.Centenarian;

                else if (age > 64)
                    return TicketType.Senior;

                else
                    return TicketType.Adult;
            }

            public static int GetPrice(TicketType ticketType)
            {
                return (int)ticketType; 
            }


            public static void CalcSingleTicket()
            {
                Console.Write("Please enter your age: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int age) && age > 0)
                {

                    TicketType ticketType = GetTicketType(age);

                    int price = GetPrice(ticketType);

                    Console.WriteLine($"The {ticketType} ticket costs {price} kr.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid age over 0.");
                }
            }
        }


    }
}
