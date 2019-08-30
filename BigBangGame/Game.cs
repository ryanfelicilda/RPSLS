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
        public string playAgain;



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
                Console.WriteLine("One cries because one is sad. I cry because others are stupid and that makes me sad.");
                RunGame();
            }

        }
        //constructor (Spawner)
        public Game()
        {
            
        }

        //member methods (Can do)
        public void RunGame()
        {
            int numOfPlayers = GetNumberOfPlayers();
            CreatePlayer(numOfPlayers);
            playerOne.ChooseName();
            playerTwo.ChooseName();

            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
                CompareGesture();
            }

            GameScore();
            RepeatGame();
            
        }
        public void CompareGesture()
        {
            if ((playerOne.gesture == "Rock" && playerTwo.gesture == "Scissors" || playerOne.gesture == "Rock" && playerTwo.gesture == "Lizard") ||
                (playerOne.gesture == "Scissor" && playerTwo.gesture == "Paper" || playerOne.gesture == "Scissor" && playerTwo.gesture == "Lizard") ||
                (playerOne.gesture == "Paper" && playerTwo.gesture == "Rock" || playerOne.gesture == "Paper" && playerTwo.gesture == "Spock") ||
                (playerOne.gesture == "Lizard" && playerTwo.gesture == "Paper" || playerOne.gesture == "Lizard" && playerTwo.gesture == "Spock") ||
                (playerOne.gesture == "Spock" && playerTwo.gesture == "Scissor" || playerOne.gesture == "Spock" && playerTwo.gesture == "Rock") == true)
            {
                Console.WriteLine("You Win!");
                playerOne.score++;
            }
            else if (playerOne.gesture == playerTwo.gesture)
            {
                Console.WriteLine("It's a tie!");
            }
            else
            {
                Console.WriteLine("Bazinga!");
                playerTwo.score++;
            }

        }

        public void GameScore()
        {
            if (playerOne.score == 2)
            {
                Console.WriteLine("Player 1 Wins!!!");
            }
            else if (playerTwo.score == 2)
            {
                Console.WriteLine("Player 2 Wins!!!");
            }
        }

        public string RepeatGame()
        {
            Console.WriteLine("Would you like to play again?");
            playAgain = Console.ReadLine().ToLower();
            return playAgain;
        }

        public void PlayAgainAnswer()
        {
            if(playAgain == "yes")
            {
                RunGame();
            }
            else if(playAgain == "no")
            {
                Console.WriteLine("Goodnight, and if there’s an apocalypse, good luck.");
            }
            else
            {
                Console.WriteLine("Goodnight, and if there’s an apocalypse, good luck.");
            }
        }

    }
}
