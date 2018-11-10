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
        private Card[] board;        

        public Board(int boardSize)
        {
            this.boardSize = boardSize;
            board = new Card[this.boardSize];
        }

        public void FillBoard(string[] words)
        {
            Random random = new Random();

            for(int boardIndex = 0; boardIndex < boardSize; boardIndex++)
            {
                do
                {
                    board[boardIndex] = new Card(words[random.Next(1, words.Length + 1)]);                    
                } while (!(CountOccurrence(board[boardIndex].Word, boardIndex) < 2));
            }
        }

        private int CountOccurrence(string word, int countToIndex)
        {
            int occ = 0;
            int index = 0;
            while (index <= countToIndex)
            {
                if(word == board[index].Word)
                {
                    occ++;
                }
            }

            return occ;
        }
    }
}
