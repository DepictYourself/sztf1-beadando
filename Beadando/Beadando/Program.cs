using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Mekkora legyen a pálya ?");
            int boardSize = int.Parse(Console.ReadLine());
            Board gameBoard = new Board(boardSize);

            gameBoard.FillBoard(FileHandler.GetRandomWordsFromFile(gameBoard.BoardSize));

            Console.WriteLine(gameBoard.GetFormattedBoard());

            Console.ReadLine();
        }
        
    }
}
