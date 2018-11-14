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
            gameBoard.FillBoard(FileHandler.GetRandomWordsFromFile(gameBoard.BoardSize));

            Game gameController = new Game(difficulty);
            do
            {
                Console.Clear();
                Console.WriteLine(gameBoard.GetFormattedBoard());
                Console.WriteLine("Adj meg két kártyát vesszővel elválasztva.");
                string[] picks = Console.ReadLine().Split(',');
                gameController.FirstPick = gameController.FormatPick(picks[0]);
                gameController.SecondPick = gameController.FormatPick(picks[1]);
                Console.WriteLine(picks[0] + ": " + gameBoard.GameBoard[gameController.FirstPick].Word);
                Console.WriteLine(picks[1] + ": " + gameBoard.GameBoard[gameController.SecondPick].Word);
                if (gameBoard.GameBoard[gameController.FirstPick].Word ==
                    gameBoard.GameBoard[gameController.SecondPick].Word)
                {
                    Console.WriteLine("TALÁLT!");
                    Thread.Sleep(2000);
                    gameBoard.GameBoard[gameController.FirstPick].Active = false;
                    gameBoard.GameBoard[gameController.SecondPick].Active = false;
                }
                else
                {
                    Console.WriteLine("Nem talált.");
                    Thread.Sleep(gameController.Difficulty * 1000);
                }
            }while (!gameController.GameOver);
            

            Console.ReadLine();
        }
        
    }
}
