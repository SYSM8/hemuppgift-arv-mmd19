using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class Board
    {
        //Public field för tillgång till andra klasser
        public int NoPins { get; set; }


      

        //Metod

        //För att ange antalet stickor
        public void SetUp(int setup) // Kontrollera att antalet stickor är mellan 1 och maxvärde
        {
            NoPins = setup;
        }

       
        public void TakePins(int takePins) 
        {
            //Kontrollera att antalet stickor som plockas inte överstiger kvarande och att antalet stickor är positivt
            while (true)
            {
                if (takePins > 0 && takePins < 3 && takePins <= NoPins)
                {
                    NoPins = NoPins - takePins;
                    break;
                }
                else
                {
                    Console.WriteLine("Ogiltig antal stickor att ta. Du får endast ta 1 eller 2.");
                    string userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out takePins))
                    {

                    }
                    else
                    {
                        Console.WriteLine("Vänligen ange ett heltal.");
                    }

                }

            }

        }

        public int GetNoPins()
        {
            return NoPins;
        }



    }
}
