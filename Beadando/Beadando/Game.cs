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
        private int difficulty;
        private int attempts;
        private int firstPick;
        private int secondPick;

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

        public int FirstPick
        {
            get { return firstPick; }
            set { firstPick = value; }
        }

        public int SecondPick
        {
            get { return secondPick; }
            set { secondPick = value; }
        }


        public Game(int difficulty)
        {
            this.gameOver = false;
            this.attempts = 0;
            this.difficulty = difficulty;
        }

        public int FormatPick(string pick)
        {
            return int.Parse(pick.Trim());
        }
    }
}
