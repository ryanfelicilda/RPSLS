using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangGame
{
    public class Player
    {

        //member variables (Has a)
        public string name;
        public string gesture;
        public int score = 0;


        public List<string> gestureChoices;


        //constructor (Spawner)
        public Player()
        {
            gestureChoices = new List<string>();
            gestureChoices.Add("Rock");
            gestureChoices.Add("Paper");
            gestureChoices.Add("Scissors");
            gestureChoices.Add("Lizard");
            gestureChoices.Add("Spock");
        }

        public virtual void ChooseName()
        {
            Console.WriteLine("Enter your name.");
            name = Console.ReadLine();
            //return name;
        }

        public virtual void ChooseGesture()
        {
            Console.WriteLine("'Rock', 'Paper', 'Scissors', 'Lizard', 'Spock'?");
            gesture = Console.ReadLine();
            //return gesture;
        }

        public void ScorePoint()
        {
            score++;
        }
        //member methods (Can do)






    }
}
