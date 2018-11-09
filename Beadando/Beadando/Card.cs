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

        public string Word
        {
            get { return word; }
            set { word = value; }
        }

        public Card(string word)
        {
            this.word = word;
        }
    }
}
