using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Rock Paper Scissor Lizard Spock.\n");
            Console.WriteLine("RULES: \n Scissors cuts paper.\n Paper covers rock.\n Rock crushes lizard.\n Lizard poisons Spock.\n Spock smashes scissors.\n Scissors decapitates lizard.\n Lizard eats paper.\n Paper disproves Spock.\n Spock vaporizes rock.\n And as it always has, rock crushes scissors.\n");

            Game game = new Game();
            game.RunGame();
        }
    }
}
