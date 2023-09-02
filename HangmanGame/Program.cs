using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int lettersNumber = 10;
            char[] guessedLetters;
            char[] word;
            bool GameOver = false;

            Console.WriteLine("Загадайте слово");

            string secretWord = Console.ReadLine();

            guessedLetters = new char[secretWord.Length];

            // Заполнение игровой строки прочерками
            for (int i = 0; i < guessedLetters.Length; i++)
            {
                guessedLetters[i] = '-';
            }
            word = secretWord.ToCharArray();

            Console.WriteLine("Теперь отгадайте введенное слово: ");

            while (!GameOver)
            {
                if (lettersNumber == 0) GameOver = true;

                for (int i = 0; i < guessedLetters.Length; i++)
                {
                    Console.Write(guessedLetters[i] + "");
                }
                Console.WriteLine();

                // Проверка, угадано ли все слово целиком
                if (!guessedLetters.Contains('-'))
                {
                    Console.WriteLine("Вы победили!");
                    break;
                }

                // Пользовательский ввод буквы
                char letter = char.Parse(Console.ReadLine());

                // Вывод на экран массива с прочерками с угаданными буквами
                if (word.Contains(letter))
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == letter)
                        {
                            guessedLetters[i] = letter;
                        }
                    }
                }
                else
                {
                    lettersNumber--;
                }
            }
        }
    }
}
