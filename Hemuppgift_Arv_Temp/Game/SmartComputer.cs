using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class SmartComputer : Player
    {
        //Konstruktor
        public SmartComputer(string userId) : base(userId) 
        { 

        }

        //Metod
        public override int TakePins(Board board)
        {
            int pinCount = board.GetNoPins(); //Hämtning av variabel för beräkningar
            int pinTake;

            if (pinCount % 3 == 0)
            {
                Random random = new Random();
                pinTake = random.Next(1, 3);
            }
            else
            {
                pinTake = pinCount % 3;
            }

            return pinTake;
        }
    }

}
