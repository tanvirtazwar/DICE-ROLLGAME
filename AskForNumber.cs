using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICE_ROLLGAME
{
    internal static class AskForNumber
    {
        public static int GiveNumber()
        {
            Console.WriteLine($"Enter number");
            string value = Console.ReadLine()!;

            bool success = int.TryParse(value, out int number);
            if (!(success))
            {
                Console.WriteLine($"Incorrect Input");
                AskForNumber.GiveNumber();
            }
            return number;
        }
    }
}
