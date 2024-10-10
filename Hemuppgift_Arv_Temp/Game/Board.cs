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
        //Private field som håller koll på antalet stickor
        private int noPins;

        //Public field för tillgång till andra klasser
        public int NoPins
        {
            get
            {
                return noPins; //Hämtar antalet stickor
            }
            set
            {
                noPins = value; //Sätter ett nytt värde på antalet stickor
            }
        }

        //Metod

        //För att ange antalet stickor
        public void SetUp(int setup, int maxValue) // Kontrollera att antalet stickor är mellan 1 och maxvärde
        {
            if (setup > 0 && setup <= maxValue) //Tilldelning för det giltiga värdet till NoPins-egenskap
            {
                noPins = setup; 
                Console.WriteLine($"Antalet stickor vid start: {NoPins}");
            }
            else
            {
                Console.WriteLine($"Vänligen ange antalet stickor mellan {maxValue}"); // Felmedelande
            }

        }

       
        public void TakePins(int takePins) 
        {
            // Kontrollerar att antalet stickor som plockas inte överstiger kvarvarande och att antalet stickor är positivt

            if(takePins == 1 || takePins == 2 && takePins <= NoPins)
            {
                NoPins -= takePins; 
                Console.WriteLine($"Tagna stickor: {takePins}, kvarvarande stickor: {NoPins}");
            }
            else if(takePins > NoPins)
            {
                Console.WriteLine("Ogiltig antal stickor att ta.");
            }
            else
            {
                Console.WriteLine("Du får endast ta 1 eller 2.");
            }
        }

        public void GetNoPins()
        {
            Console.WriteLine($"Antalet stickor kvar: {NoPins}"); //Utskrift av antalet kvarstående stickor.
        }



    }
}
