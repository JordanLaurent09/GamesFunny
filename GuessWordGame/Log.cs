using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GuessWordGame
{
    /* Класс Log записывает результаты игры в файл, а именно - 
     * имя игрока, количество очков, а также его состояние - т.е.
     * выигрыш или проигрыш */
    class Log
    {
        public List<string> ReadFile()
        {
            List<string> fileContent = new List<string>();
            fileContent = File.ReadAllLines(@"Ratings.txt").ToList();
            return fileContent;
        }

        public void PrepareInfo(Player player, List<string> playerInfo)
        {
            playerInfo.Add("Имя игрока: " + player.name);
            playerInfo.Add("Рейтинг игрока: " + player.points);
            playerInfo.Add("Результат игрока: " + player.playerState);
        }

        public void WriteData(List<string> playerInformation)
        {
            File.WriteAllLines(@"Ratings.txt", playerInformation);
        }
    }
}
