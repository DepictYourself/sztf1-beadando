using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Beadando
{
    class FileHandler
    {
        private string filePath;

        public FileHandler()
        {
            this.filePath = Directory.GetCurrentDirectory();
        }

        public FileHandler(string filePath)
        {
            this.filePath = filePath;
        }

        public string[] GetWordsFromFile(string filePath)
        {
            //TODO implement missing functionality to get word from file.
            return new string[] { "Disszipáció", "Soros"};
        }
    }
}
