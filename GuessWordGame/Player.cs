using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GuessWordGame
{
    /* В классе Player содержится сам игрок, его характеристики,
     * а также методы, позволяющие игроку совершать игровые действия */
    class Player
    {
        public string name;
        public int points = 10;
        public string playerState;



        // Получение игроком списка слов
        public List<string> PrepareWords()
        {
            return File.ReadAllLines(@"Movies.txt").ToList();
        }

        // Случайный выбор слова из списка
        public string GetRandomWord(List<string> wordList)
        {
            Random random = new Random();
            return wordList[random.Next(0, wordList.Count)];
        }

        // Преобразование слова в массив символов
        public char[] getCharArray(string word)
        {
            return word.ToCharArray();
        }

        // Алгоритм поиска заданного слова
        public string SeekingWord(char[] secretWord)
        {
            string state = "";

            char[] resultWord = new char[secretWord.Length];

            for (int i = 0; i < resultWord.Length; i++)
            {
                resultWord[i] = '_';
            }

            while (true)
            {
                for (int i = 0; i < resultWord.Length; i++)
                {
                    Console.Write(resultWord[i]);
                }

                Console.Write(Environment.NewLine);

                if (this.points == 0)
                {
                    state = "НЕ УГАДАЛ";
                    break;
                }

                if (!resultWord.Contains('_'))
                {
                    state = "УГАДАЛ";
                    break;
                }

                Console.WriteLine("Пожалуйста, введите букву");
                char letter = char.Parse(Console.ReadLine());

                if (secretWord.Contains(letter))
                {
                    for (int i = 0; i < secretWord.Length; i++)
                    {
                        if (secretWord.ElementAt(i) == letter)
                        {
                            resultWord[i] = letter;
                        }
                    }
                }
                else
                {
                    this.points--;
                }
            }
            return state;
        }
    }
}
