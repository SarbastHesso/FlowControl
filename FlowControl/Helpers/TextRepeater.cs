using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl.Helpers
{
    public class TextRepeater
    {
        public static void RepeatInput ()
        {
            Console.WriteLine("Enter som text to repeat:");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($" {i+1}.{input} ");
                }
            }
            else
            {
                Console.WriteLine("You should enter an input to repeat");
            }
        }
    }
}
