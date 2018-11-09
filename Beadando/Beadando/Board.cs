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

            

            //TODO Figure out htf should i implement this.
        }
    }
}
