using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangGame
{
    class Human : Player
    {
        public override void ChooseName()
        {
            Console.WriteLine("\nEnter your name?\n");
            name = Console.ReadLine();
        }
        public override void ChooseGesture()
        {
            Console.WriteLine("\n" + name + " choose (1) Rock, (2) Paper, (3) Scissors, (4) Lizard, (5) Spock?\n");
            int choice = int.Parse(Console.ReadLine());
            playerGesture = gesture[choice - 1];
            Console.Clear();
        }
    }



}
