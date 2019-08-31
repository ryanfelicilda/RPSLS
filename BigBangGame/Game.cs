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
            if ((playerOne.gesture.ToLower() == "Rock" && playerTwo.gesture.ToLower() == "Scissors" || playerOne.gesture.ToLower() == "Rock" && playerTwo.gesture.ToLower() == "Lizard") ||
                (playerOne.gesture.ToLower() == "Scissors" && playerTwo.gesture.ToLower() == "Paper" || playerOne.gesture.ToLower() == "Scissors" && playerTwo.gesture.ToLower() == "Lizard") ||
                (playerOne.gesture.ToLower() == "Paper" && playerTwo.gesture.ToLower() == "Rock" || playerOne.gesture.ToLower() == "Paper" && playerTwo.gesture.ToLower() == "Spock") ||
                (playerOne.gesture.ToLower() == "Lizard" && playerTwo.gesture.ToLower() == "Paper" || playerOne.gesture.ToLower() == "Lizard" && playerTwo.gesture.ToLower() == "Spock") ||
                (playerOne.gesture.ToLower() == "Spock" && playerTwo.gesture.ToLower() == "Scissors" || playerOne.gesture.ToLower() == "Spock" && playerTwo.gesture.ToLower() == "Rock") == true)
            {
                Console.WriteLine("{0} win!\n", playerOne.name);
                playerOne.score++;
            }
            else if (playerOne.gesture.ToLower() == playerTwo.gesture.ToLower())
            {
                Console.WriteLine("It's a tie!\n");
            }
            else
            {
                Console.WriteLine("{0} win!\n", playerTwo.name);
                playerTwo.score++;
            }

        }

        //public void CompareGesture()
        //{
        //    Console.WriteLine();
        //    switch (playerOne.gestureChoices)
        //    {
        //        case 1 = "Rock"
        //    }
        //}

        public void GameScore()
        {
            if (playerOne.score == 2)
            {
                Console.WriteLine("{0} wins the game!!!\n", playerOne.name);
            }
            else if (playerTwo.score == 2)
            {
                Console.WriteLine("{0} wins the game!!!\n", playerTwo.name);
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
            if(playAgain == "yes")
            {
                RunGame();
            }
            else if(playAgain == "no")
            {
                Console.WriteLine("Goodbye, and if there’s an apocalypse, good luck.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid input. Goodbye, and if there's an apocalypes, good luck.");
                RepeatGame();
            }
        }

    }
}
