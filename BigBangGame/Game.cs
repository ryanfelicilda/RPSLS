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
        public int numberOfPlayers;
        public bool winLose;

        public int GetNumberOfPlayers()
        {
            Console.WriteLine("One Player or Two Player? Enter 1 or 2.");
            numberOfPlayers = int.Parse(Console.ReadLine());
            return numberOfPlayers;

        }

        public void CreatePlayer(int number)
        {
            if(number == 1)
            {
                playerOne = new Human();
                playerTwo = new Computer();
            }
            else if(number == 2)
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
            else
            {
                Console.WriteLine("People should have chips implanted in their skull that should explode when they say or do something stupid.");
            }

        }
        //constructor (Spawner)
        public Game()
        {
            
        }

        //member methods (Can do)
        public void RunGame()
        {
            Console.WriteLine("Welcome To Rock Paper Scissor Lizard Spock.");
            Console.WriteLine("If you don't know the rules, scissors cuts paper, paper covers rock, rock crushes lizard, lizard poisons Spock, Spock smashes scissors, scissors decapitates lizard, lizard eats paper, paper disproves Spock, Spock vaporizes rock, and as it always has, rock crushes scissors.");
            int numOfPlayers = GetNumberOfPlayers();
            CreatePlayer(numOfPlayers);
            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();
            CompareGesture();
        }
        public void CompareGesture()
        {
            if((playerOne.gesture == "Rock" && playerTwo.gesture == "Scissors" || playerOne.gesture == "Rock" && playerTwo.gesture == "Lizard") ||
               (playerOne.gesture == "Scissor" && playerTwo.gesture == "Paper" || playerOne.gesture == "Scissor" && playerTwo.gesture == "Lizard") ||
               (playerOne.gesture == "Paper" && playerTwo.gesture == "Rock" || playerOne.gesture == "Paper" && playerTwo.gesture == "Spock") ||
               (playerOne.gesture == "Lizard" && playerTwo.gesture == "Paper" || playerOne.gesture == "Lizard" && playerTwo.gesture == "Spock") ||
               (playerOne.gesture == "Spock" && playerTwo.gesture == "Scissor" || playerOne.gesture == "Spock" && playerTwo.gesture == "Rock") == true)
            {
                Console.WriteLine("You Win!");
                playerOne.score++;
            }
            else if(playerOne.gesture == playerTwo.gesture)
            {
                Console.WriteLine("It's a tie!");
            }
            else
            {
                Console.WriteLine("Bazinga!");
                playerTwo.score++;
            }
        }

        


    }
}
