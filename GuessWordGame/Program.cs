using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessWordGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запуск игры - создание объекта класса Game
            Game game = new Game();

            // Создание игрока
            Player player = game.CreatePlayer();

            // Получение игроком списка фильмов
            List<string> wordList = player.PrepareWords();

            // Выдача игроку случайного фильма для угадывания названия
            game.secretWord = player.GetRandomWord(wordList);

            // Преобразование строки с названием фильма в зашифрованный массив символов, отображаемый на экране
            char[] secret = player.getCharArray(game.secretWord);

            // Игрок пытается угадать название фильма и по итогу своих попыток получает статус
            player.playerState = player.SeekingWord(secret);

            // Создание объекта класса Log - для ведения журнала успехов игроков
            Log log = new Log();

            // Следующие действия заполняют журнал
            List<string> fileContent = log.ReadFile();

            log.PrepareInfo(player, fileContent);

            log.WriteData(fileContent);
        }
    }
}
