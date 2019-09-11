using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangGame
{
    public class Game
    {
        Player playerOne;
        Player playerTwo;
        public int score = 0;

        public int GetNumberOfPlayers()
        {
            Console.WriteLine("One Player or Two Player? Enter 1 or 2.\n");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            return numberOfPlayers;
        }

        public void CreatePlayers(int number)
        {

            if (number == 1)
            {
                playerOne = new Human();
                playerTwo = new Computer();
            }
            else if (number == 2)
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
            else
            {
                Console.WriteLine("One cries because one is sad.I cry because others are stupid and that makes me sad.\n Choose again.\n");
                RunGame();
            }
        }
        public Game()
        {

        }
        public void RunGame()
        {
            int numberOfPlayers = GetNumberOfPlayers();
            CreatePlayers(numberOfPlayers);
            playerOne.ChooseName();
            playerTwo.ChooseName();

            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
                CompareGesture();
            }
            GameScore();
            RepeatGameAnswer();
        }
        public void CompareGesture()
        {
            if ((playerOne.playerGesture == "Rock" && playerTwo.playerGesture == "Scissors" || playerOne.playerGesture == "Rock" && playerTwo.playerGesture == "Lizard") ||
              (playerOne.playerGesture == "Scissors" && playerTwo.playerGesture == "Paper" || playerOne.playerGesture == "Scissors" && playerTwo.playerGesture == "Lizard") ||
              (playerOne.playerGesture == "Paper" && playerTwo.playerGesture == "Rock" || playerOne.playerGesture == "Paper" && playerTwo.playerGesture == "Spock") ||
              (playerOne.playerGesture == "Lizard" && playerTwo.playerGesture == "Paper" || playerOne.playerGesture == "Lizard" && playerTwo.playerGesture == "Spock") ||
              (playerOne.playerGesture == "Spock" && playerTwo.playerGesture == "Scissors" || playerOne.playerGesture == "Spock" && playerTwo.playerGesture == "Rock") == true)
            {
                Console.WriteLine(playerOne.name + "\nWins!\n");
                playerOne.score++;
            }
            else if (playerOne.playerGesture == playerTwo.playerGesture)
            {
                Console.WriteLine("\nIt's a tie!\n");
            }
            else
            {
                Console.WriteLine(playerTwo.name + "\nWins!\n");
                playerTwo.score++;
            }
        }
        public void GameScore()
        {
            if (playerOne.score == 2)
            {
                Console.WriteLine(playerOne.name + "\nWins the game!");
            }
            else if (playerTwo.score == 2)
            {
                Console.WriteLine(playerTwo.name + "\nWins the game!");
            }
        }
        public void RepeatGameAnswer()
        {
            Console.WriteLine("Would you like to play again? Enter (Y) yes or (N) no\n");
            string answer = Console.ReadLine().ToLower();

            if (answer == "y")
            {
                RunGame();
            }
            else if (answer == "n")
            {
                Console.WriteLine("Goodbye, and if there’s an apocalypse, good luck.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid input. Goodbye, and if there's an apocalypes, good luck.");
                RepeatGameAnswer();
            }

        }
    }
}
