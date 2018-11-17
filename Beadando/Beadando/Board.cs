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
        private int numOfPairs;

        public int BoardSize
        {
            get { return boardSize; }
        }

        public Card[] GameBoard
        {
            get { return gameBoard; }
        }

        public int NumOfPairs
        {
            get { return numOfPairs; }
            set { numOfPairs = value; }
        }


        public Board(int boardSize)
        {
            this.boardSize = boardSize;
            gameBoard = new Card[this.boardSize];
            this.numOfPairs = boardSize / 2;
        }


        public string GetFormattedBoard()
        {
            //Ez a metódus egy stringet csinál a gameBoard tömbből.
            string formattedGameBoard = "";
            for(int i = 0; i < gameBoard.Length; i++)
            {
                //Ha egy kártya aktív akkor kiírjuk a számot.
                if (gameBoard[i].Active)
                {
                    //A tábla szélén törjük a sort.
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

        public bool ValidatePicks(int firstPick, int secondPick)
        {
            if (firstPick == secondPick ||
                gameBoard[firstPick].Active == false ||
                gameBoard[secondPick].Active == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
