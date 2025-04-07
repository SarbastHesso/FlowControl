using FlowControl.Enums;
using FlowControl.Helpers;

namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isAlive = true;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to main menu, please choose an option by entering corresponding number");
                Console.WriteLine("0. Quit the program");
                Console.WriteLine("1. Single ticket price based on age");
                Console.WriteLine("2. Total price for a group");
                Console.WriteLine("3. Repeat input 10 times");
                Console.WriteLine("4. Get the third word from a sentence");
   

                string input = Console.ReadLine();

                if (Enum.TryParse(input, out MenuOptions option))
                {
                    switch (option)
                    {
                        case MenuOptions.Quit:
                            Console.WriteLine("Exiting the program...");
                            isAlive = false;
                            break;

                        case MenuOptions.SingleTicket:
                            SingleTicketCalculator.CalcSingleTicket();
                            break;

                        case MenuOptions.GroupTicket:
                            GroupTicketCalculator.CalcGroupTicket();
                            break;

                        case MenuOptions.RepeatText:
                            TextRepeater.RepeatInput();
                            break;

                        case MenuOptions.ThirdWord:
                            SentenceParser.GetThirdWord();
                            break;

                        default:
                            Console.WriteLine("Invalid input. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }


            } while (isAlive);
        }
    }
}
