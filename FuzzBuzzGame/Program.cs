using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzBuzzGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;

            string answer;

            bool gameOver = false;

            Console.WriteLine("Введите количество участников");

            int playersAmount = int.Parse(Console.ReadLine());

            int[] players = new int[playersAmount];

            // Массив игроков заполняется порядковыми номерами игроков, начиная с номера 1
            for (int i = 0; i < playersAmount; i++)
            {
                players[i] = (i + 1);
            }
            // Массив с номерами выбывших из игры игроков, нужен для того,чтобы они пропускали ходы
            // Массив заполняется по ходу игры
            int[] losers = new int[playersAmount];

            while (!gameOver)
            {
                for (int i = 0; i < players.Length; i++)
                {
                    if (losers.Contains(i + 1)) continue;

                    if (playersAmount == 1)
                    {
                        Console.WriteLine(players[i] + "-й игрок победил!");
                        gameOver = true;
                        break;
                    }

                    Console.WriteLine("Ходит " + players[i] + "-й игрок");
                    Console.WriteLine("Текущее число - " + number);

                    if (number % 3 == 0 && number % 5 != 0)
                    {
                        answer = "Fizz";
                    }
                    else if (number % 3 != 0 && number % 5 == 0)
                    {
                        answer = "Buzz";
                    }
                    else if (number % 3 == 0 && number % 5 == 0)
                    {
                        answer = "Fizz-Buzz";
                    }
                    else
                    {
                        answer = number.ToString();
                    }

                    Console.WriteLine("Введите ответ - само число, Fizz, Buzz или Fizz-Buzz");
                    string yourAnswer = Console.ReadLine();
                    if (answer == yourAnswer)
                    {
                        Console.WriteLine(players[i] + "-й игрок угадал!");
                    }
                    else
                    {
                        Console.WriteLine(players[i] + "-й игрок не угадал и выбывает из игры!");
                        losers[i] = players[i];
                        playersAmount--;
                    }
                    number++;

                    if (number > 100)
                    {
                        Console.WriteLine("Определить победителя не удалось, так как кончились все числа");
                        gameOver = true;
                        break;
                    }
                }
            }
        }
    }
}
