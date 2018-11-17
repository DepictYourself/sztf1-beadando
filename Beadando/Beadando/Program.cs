using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Beadando
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mekkora legyen a pálya ?");
            int boardSize = int.Parse(Console.ReadLine());
            Console.WriteLine("Nehézség (Hány másodpercig mutassuk a szavakat)");            
            int difficulty = int.Parse(Console.ReadLine());

            Board gameBoard = new Board(boardSize);
            FileHandler fileHandler = new FileHandler();

            gameBoard.FillBoard(fileHandler.GetRandomWordsFromFile(gameBoard.BoardSize));

            Game gameController = new Game(difficulty);

            do
            {
                Console.Clear();

                Console.WriteLine(gameBoard.GetFormattedBoard());
                string[] picks;

                do
                {
                    Console.WriteLine("Adj meg két kártyát vesszővel elválasztva.");
                    picks = Console.ReadLine().Split(',');
                    gameController.FirstPick = gameController.FormatPick(picks[0]);
                    gameController.SecondPick = gameController.FormatPick(picks[1]);
                } while (!gameBoard.ValidatePicks(gameController.FirstPick, gameController.SecondPick));
                
                
                Console.WriteLine(picks[0] + ": " + gameBoard.GameBoard[gameController.FirstPick].Word);
                Console.WriteLine(picks[1] + ": " + gameBoard.GameBoard[gameController.SecondPick].Word);
                gameController.Attempts++;

                if (gameBoard.GameBoard[gameController.FirstPick].Word ==
                    gameBoard.GameBoard[gameController.SecondPick].Word)
                {
                    Console.WriteLine("TALÁLT!");
                    gameBoard.GameBoard[gameController.FirstPick].Active = false;
                    gameBoard.GameBoard[gameController.SecondPick].Active = false;
                    gameBoard.NumOfPairs--;
                }
                else
                {
                    Console.WriteLine("Nem talált.");
                }
                Console.WriteLine("Eddigi próbálkozások száma: {0}", gameController.Attempts);
                Console.WriteLine("Hátralévő páros száma: {0}", gameBoard.NumOfPairs);
                Thread.Sleep(gameController.Difficulty * 1000);

                if (gameBoard.NumOfPairs == 0)
                {
                    gameController.GameOver = true;
                }

            } while (!gameController.GameOver);
            Console.Clear();
            Console.WriteLine("Gratulálok, Nyertél! {0} lépésből. Vége a játéknak.", gameController.Attempts);
            Console.WriteLine("Nyomj meg egy gombot a kilépéshez.");
            Console.ReadLine();
        }
        
    }
}
