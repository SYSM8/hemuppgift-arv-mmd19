using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class HumanPlayer : Player
    {

        //Konstruktor
        public HumanPlayer(string userId) : base(userId) { }
        public override int TakePins(Board board)
        {
            int taken = 0;
            bool validInput = false; //Variabel för att kontrollera giltig inmatning

            //While-loop som körs tills användaren matar in giltig data
            while (!validInput)
            {
                try
                {
                    Console.WriteLine("Ange hur många stickor du vill plocka.:");
                    taken = Convert.ToInt32(Console.ReadLine());

                    //Kontrollera om inmatningen är giltig
                    if (taken < 1 || taken > 2)
                    {
                        Console.WriteLine("Du måste ange ett heltal, 1 eller 2");
                    }
                    else if (taken > board.GetNoPins())
                    {
                        Console.WriteLine($"Det finns inte tillräckligt med stickor. Kvarvarande:{board.GetNoPins()}");
                    }
                    else
                    {
                        validInput = true;
                       
                    }
                }
                catch (FormatException)
                {
                    //Hantering vid ogiltig inmatning
                    Console.WriteLine("Ogiltig inmatning. Ange ett heltal 1-2.");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                }
            }
                return taken;
            

            

        }
    }
}       
                
          

        
    
    


