using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICE_ROLLGAME
{
    internal class DiceRoll
    {
        private readonly int diceNumber = new Random().Next(1, 7);

        public void Play()
        {
            do
            {
                int userInput = AskForNumber.GiveNumber();
                var newTrial = new Trial(diceNumber, userInput);
                if (newTrial.TrialResult) { Console.WriteLine("You Won"); break; }
                else if (Trial.CountOfTrial == 3) { Console.WriteLine("You lose"); }
                else { Console.WriteLine("Wrong Answer"); }
            } while (Trial.CountOfTrial < 3);
        }
    }
}
