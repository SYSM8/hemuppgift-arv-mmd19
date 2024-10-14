using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class ComputerPlayer : Player
    {
        Random random = new Random(); //Skapar ett random obj för att generera slumpmässiga tal

        //Konstruktor
        public ComputerPlayer(string UserId) : base(UserId)
        {

        }

        //Metod
        public override int TakePins(Board board)
        {
            //Slumpmässigt väljer 1 eller två stickor.
            int NoPins = board.NoPins;
            int taken;

            if(NoPins == 1)
            {
                taken = 1;
                Console.WriteLine($"Siri tar {taken} sticka");
            }
           
            else
            {
                taken=random.Next(1, Math.Min(3,NoPins+1));
                Console.WriteLine($"Siri tar {taken} stickor");
            }

            board.TakePins(taken);
            return NoPins; //Returnerar det antal stickor som togs
        }



    }
}
