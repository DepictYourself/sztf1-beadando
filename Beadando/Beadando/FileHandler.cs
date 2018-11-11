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
        private string fileName = "teszt.txt";

        public FileHandler()
        {
            this.filePath = Directory.GetCurrentDirectory();
        }

        public FileHandler(string filePath)
        {
            this.filePath = filePath;
        }

        public static string[] GetRandomWordsFromFile(int boardSize)
        {
            //TODO implement missing functionality to get word from file.
            string[] words = new string[] { "Disszipáció", "Soros", "Valami", "Alma", "Bicigli", "Kukac", "Macbook", "Szar" };
            Random random = new Random();
            string[] randomWordArray = new string[boardSize / 2];
            for (int i = 0; i < randomWordArray.Length; i++)
            {
                do
                {
                    randomWordArray[i] = words[random.Next(0, words.Length)];
                } while (!(CountOccurrence(randomWordArray, randomWordArray[i], i) <= 1));
            }

            return randomWordArray;
        }

        private static int CountOccurrence(string[]randomWordArray, string word, int countToIndex)
        {
            int occ = 0;
            for (int index = 0; index <= countToIndex; index++)
            {
                if (word == randomWordArray[index])
                {
                    occ++;
                }
            }

            return occ;
        }
    }
}
