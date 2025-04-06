using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl.Helpers
{
    public class SentenceParser
    {
        public static void GetThirdWord ()
        {
            Console.WriteLine("Pleas enter a sentence with at least 3 words");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (words.Length >= 3)
                {
                    Console.WriteLine($"The third word is: {words[2]}");
                }
                else
                {
                    Console.WriteLine("The input should contain at least 3 words");
                }

            }
            else
            {
                Console.WriteLine("You need to enter a sentence");
            }
        }
    }
}
