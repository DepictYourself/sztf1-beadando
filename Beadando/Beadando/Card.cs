using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando
{
    class Card
    {
        private string word;
        private bool active;

        public string Word
        {
            get { return word; }
            set { word = value; }
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        public Card(string word)
        {
            this.word = word;
            active = true;
        }
    }
}
