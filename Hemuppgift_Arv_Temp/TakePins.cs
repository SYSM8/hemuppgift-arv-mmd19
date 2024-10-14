using Hemuppgift_Arv_Temp.Game;

namespace Hemuppgift_Arv_Temp
{
    /*F2 a) Klassen Player är en basklass till HumanPlayer & ComputerPlayer

        b) De korrekta tilldelningsatserna är:
        2) Player p = new HumanPlayer("Alicent");
        3) HumanPlayer p = new HumanPlayer("Rhaenyra");*/
    internal class TakePins
    {
        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {
            Board board = new Board();
            board.SetUp(40);


            Player player1 = new HumanPlayer("Jenny Nguyen");
            //Player player2 = new ComputerPlayer("Siri Jobs");
            Player player3 = new SmartComputer("Alexa Google");



            Console.WriteLine($"Välkommen {player1.GetUserId()}!" +
                $" Du ska nu plocka upp den sista stickan från vårt mystiska bord." +
                $"Varje drag ger dig möjlighet att ta antingen 1-2 stickor, så välj klokt. " +
                $"Den som tar den sista stickan kommer att bli vår hedersamma vinnare! ");


            //While-loop för spelets gång
            while (board.GetNoPins() > 0)
            {
                //Spelare 1 (Human)

                int player1taken = player1.TakePins(board);
                board.TakePins(player1taken);

                Console.WriteLine($"Kvarvarande stickor: {board.NoPins}. efter {player1.GetUserId()}s tur.");




                //Kontrollera om spelaren har vunnit.
                if (board.GetNoPins() == 0)
                {
                    Console.WriteLine("Grattis, du vann!");
                    return; //Avslutar spelet
                }


                //Spelare 2 (Computer)
                
                //int player2taken=player2.TakePins(board);
                //Console.WriteLine($"Kvarvarande stickor: {board.NoPins} efter {player2.GetUserId()}s tur.");


                ////Kontrollerar om datorn har vunnit 
                //if (board.GetNoPins() == 0)
                //{
                //    Console.WriteLine("Game over, Siri Jobs vann!");
                //    return; //Avslutar spelet
                //}


                // Spelare 3 (SmartComputer)
                int player3taken = player3.TakePins(board);
                board.TakePins(player3taken);
                Console.WriteLine($"Alexa tar: {player3taken}. Kvarvarande stickor: {board.NoPins} efter {player3.GetUserId()}s tur");

                if(board.GetNoPins() == 0)
                {
                    Console.WriteLine("Game over, Alexa Google vann!");
                    return; //Avslutar spelet
                }
            }


        }

    }
}
