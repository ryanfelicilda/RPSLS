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
                var random = new Random();
                var list = new List<string> { };
                int sheldonGesture = random.Next(gesture.Count);
                playerGesture = gesture[sheldonGesture];
        }
            public override void ChooseName()
            {
                Console.WriteLine("\nHello, I'm Dr. Sheldon Cooper. I'm exceedingly smart. I graduated college at 14. Good luck trying to beat me.\n");
            }
        }
}
