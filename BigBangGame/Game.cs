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
            Console.WriteLine("One Player or Two Player? Enter 1 or 2.\n");
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
                Console.WriteLine("One cries because one is sad. I cry because others are stupid and that makes me sad.\n Choose again.\n");
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
            var playAgain = RepeatGame();
            PlayAgainAnswer(playAgain);
            
        }
        public void CompareGesture()
        {
            if ((playerOne.gesture == "Rock" && playerTwo.gesture == "Scissors" || playerOne.gesture == "Rock" && playerTwo.gesture == "Lizard") ||
                (playerOne.gesture == "Scissor" && playerTwo.gesture == "Paper" || playerOne.gesture == "Scissor" && playerTwo.gesture == "Lizard") ||
                (playerOne.gesture == "Paper" && playerTwo.gesture == "Rock" || playerOne.gesture == "Paper" && playerTwo.gesture == "Spock") ||
                (playerOne.gesture == "Lizard" && playerTwo.gesture == "Paper" || playerOne.gesture == "Lizard" && playerTwo.gesture == "Spock") ||
                (playerOne.gesture == "Spock" && playerTwo.gesture == "Scissor" || playerOne.gesture == "Spock" && playerTwo.gesture == "Rock") == true)
            {
                Console.WriteLine("You Win!\n");
                playerOne.score++;
            }
            else if (playerOne.gesture == playerTwo.gesture)
            {
                Console.WriteLine("It's a tie!\n");
            }
            else
            {
                Console.WriteLine("Bazinga!\n");
                playerTwo.score++;
            }

        }

        public void GameScore()
        {
            if (playerOne.score == 2)
            {
                Console.WriteLine("Player 1 Wins!!!\n");
            }
            else if (playerTwo.score == 2)
            {
                Console.WriteLine("Player 2 Wins!!!\n");
            }
        }

        public string RepeatGame()
        {
            Console.WriteLine("Would you like to play again? Enter 'yes' or 'no'\n");
            playAgain = Console.ReadLine().ToLower();
            return playAgain;
        }

        public void PlayAgainAnswer(string playAgain)
        {
            if(playAgain == "yes\n")
            {
                RunGame();
            }
            else if(playAgain == "no\n")
            {
                Console.WriteLine("Goodbye, and if there’s an apocalypse, good luck.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid input. Goodbye, and if there's an apocalypes, good luck.");
                Console.ReadLine();
            }
        }

    }
}
