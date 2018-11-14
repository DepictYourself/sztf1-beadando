using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando
{
    class Board
    {
        private int boardSize;
        private Card[] gameBoard;

        public int BoardSize
        {
            get { return boardSize; }
        }

        public Card[] GameBoard
        {
            get { return gameBoard; }
        }


        public Board(int boardSize)
        {
            this.boardSize = boardSize;
            gameBoard = new Card[this.boardSize];
        }


        public string GetFormattedBoard()
        {
            string formattedGameBoard = "";
            for(int i = 0; i < gameBoard.Length; i++)
            {
                if (gameBoard[i].Active)
                {
                    if ((i + 1) % Math.Sqrt(boardSize) == 0)
                    {
                        formattedGameBoard += (i + 1) + " \n";
                    }
                    else if (i + 1 < 10)
                    {
                        formattedGameBoard += (i + 1) + "  ";
                    }
                    else
                    {
                        formattedGameBoard += (i + 1) + " ";
                    }
                }else
                {
                    if((i + 1) % Math.Sqrt(boardSize) == 0)
                    {
                        formattedGameBoard += "   \n";
                    }
                    else
                    {
                        formattedGameBoard += "   ";
                    }                    
                }

            }

            return formattedGameBoard;
        }

        public void FillBoard(string[] words)
        {
            Random random = new Random();

            for(int boardIndex = 0; boardIndex < boardSize; boardIndex++)
            {
                do
                {
                    gameBoard[boardIndex] = new Card(words[random.Next(0, words.Length)]);                    
                } while (!(CountOccurrence(gameBoard[boardIndex].Word, boardIndex) <= 2));
            }
        }

        private int CountOccurrence(string word, int countToIndex)
        {
            int occ = 0;
            for(int index = 0; index <= countToIndex; index++)
            {
                if (word == gameBoard[index].Word)
                {
                    occ++;
                }
            }

            return occ;
        }
    }
}
