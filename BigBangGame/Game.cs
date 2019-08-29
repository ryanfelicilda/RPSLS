using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangGame
{
    class Game
    {

        //member variables (Has a)
        public Player playerOne;
        public Player playerTwo;
        public string index;
        public int keepScore = 0;
        public bool winLose;

        //constructor (Spawner)
        public Game()
        {
            
        }

        //member methods (Can do)
        public void Win()
        {
            winLose = true;
        }

        public void ScorePoint()
        {
            keepScore++;
        }


    }
}
