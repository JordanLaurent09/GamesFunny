using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessWordGame
{
    /* Класс Game запускает игру,а именно - 
     * создает игрока */
    class Game
    {
        public string secretWord;


        // Метод по созданию игрока

        public Player CreatePlayer()
        {
            Player player = new Player();
            Console.WriteLine("Назови себя: ");
            player.name = Console.ReadLine();
            return player;
        }
    }
}
