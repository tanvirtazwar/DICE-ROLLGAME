using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICE_ROLLGAME
{
    internal class Trial
    {
        private int diceNumber;
        private int userInput;
        public static int CountOfTrial { get; private set; }
        public bool TrialResult { get; private set; }

        public Trial(int diceNumber, int userInput)
        {
            this.diceNumber = diceNumber;
            this.userInput = userInput;
            ++CountOfTrial;
            TrialResult = (diceNumber == userInput);
        }
    }
}
