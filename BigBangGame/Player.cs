using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangGame
{
    class Player
    {

        //member variables (Has a)
        public string gesture;


        //constructor (Spawner)


        public Player()
        {
            List<string> gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
        }

        //member methods (Can do)
        public void chooseGesture()
        {
            Console.WriteLine("'Rock', 'Paper', 'Scissors', 'Lizard', 'Spock'?");
            string newGesture = Console.ReadLine();
            gesture = newGesture;
        }

        
       


    }
}
