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
        private string fileName = "szotar.txt";

        public string[] GetRandomWordsFromFile(int boardSize)
        {
            string[] words = GetAllWords();

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

        private string[] GetAllWords()
        {
            StreamReader sr = new StreamReader(fileName);
            string allWords = sr.ReadToEnd();
            string[] wordArray = allWords.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            return wordArray;            
        }

        private int CountOccurrence(string[]randomWordArray, string word, int countToIndex)
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
