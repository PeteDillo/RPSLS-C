using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {
        public string gestureChoice;
        public int numberOfWins;
        public string[] gestureChoices = { "rock", "paper", "scissors", "lizard", "spock" };

    }

    public void GestureSelect()
    {
        Console.WriteLine("Choose your gesture:");
        int index = 0;
        foreach (string gesture in gestureChoices)
        {
            Console.WriteLine("Press", index, "");
            index++;
        }
    }
}


