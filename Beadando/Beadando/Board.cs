﻿using System;
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

        public int BoardSize
        {
            get { return boardSize; }
        }


        public Board(int boardSize)
        {
            this.boardSize = boardSize;
            board = new Card[this.boardSize];
        }


        public string GetFormattedBoard()
        {
            string formattedGameBoard = "";
            for(int i = 0; i < board.Length; i++)
            {
                if(i + 1 % Math.Sqrt(boardSize) == 0)
                {
                    formattedGameBoard += board[i].Word + ";\n";
                }else
                {
                    formattedGameBoard += board[i].Word + ";";
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
                    board[boardIndex] = new Card(words[random.Next(0, words.Length)]);                    
                } while (!(CountOccurrence(board[boardIndex].Word, boardIndex) <= 2));
            }
        }

        private int CountOccurrence(string word, int countToIndex)
        {
            int occ = 0;
            for(int index = 0; index <= countToIndex; index++)
            {
                if (word == board[index].Word)
                {
                    occ++;
                }
            }

            return occ;
        }
    }
}
