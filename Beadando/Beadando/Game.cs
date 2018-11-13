using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando
{
    class Game
    {
        private bool gameOver;
        private int attempts;
        private int difficulty;

        public bool GameOver
        {
            get { return gameOver; }
            set { gameOver = value; }
        }

        public int Attempts
        {
            get { return attempts; }
            set { attempts = value; }
        }

        public int Difficulty
        {
            get { return difficulty; }
        }


        public Game(int difficulty)
        {
            this.gameOver = false;
            this.attempts = 0;
            this.difficulty = difficulty;
        }


        public bool Pick(string firstWord, string secondWord)
        {
            if(firstWord.Trim() == secondWord.Trim())
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
