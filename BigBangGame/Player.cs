using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangGame
{
    public abstract class Player
    {
        public string name;
        public string PlayerChoice;
        public int score = 0;
        public List<string> gesture = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        
        public Player()
        {

        }
        public abstract void ChooseGesture();
        public abstract void ChooseName();
    }
}

