using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangGame
{
        class Computer : Player
        {
            public override void ChooseGesture()
            {
                Console.WriteLine("Sheldon");
                Random random = new Random();
                int computerChoice = random.Next(1, 6);
                PlayerChoice = computerChoice.ToString();
            }
            public override void ChooseName()
            {
                Console.WriteLine("\nHello, I'm Dr. Sheldon Cooper. I'm exceedingly smart. I graduated college at 14. Good luck trying to beat me.\n");
            }
        }
}
