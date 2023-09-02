using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatEngineerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mineField = new int[3, 3];
            int[,] gameField = new int[3, 3];
            int count = 0;
            int y;
            int x;
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    gameField[j, i] = 0;
                    Console.Write(gameField[j, i] + " ");
                }
                Console.WriteLine();
            }

            mineField = MiningTerritory(mineField);


            while (true)
            {
                Console.WriteLine("Введите координату y");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите координату x");
                x = int.Parse(Console.ReadLine());
                if (mineField[y, x] == 2)
                {
                    Console.WriteLine("ВЗРЫВ!!!");
                    break;
                }
                else if (mineField[y, x] == 0)
                {
                    gameField[y, x] = 6;
                    Draw2DArray(gameField);
                    count++;
                    if (count == 6)
                    {
                        Console.WriteLine("Поле разминировано");
                        break;
                    }
                }
            }

            // Функция, расставляющая мины по полю
            int[,] MiningTerritory(int[,] mines)
            {
                mines[2, 2] = 2;
                mines[1, 0] = 2;
                mines[0, 2] = 2;

                return mines;
            }

            // Функция, отрисовывающая игровое поле
            void Draw2DArray(int[,] array2D)
            {
                for (int b = 0; b < 3; b++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        Console.Write(array2D[b, c] + " ");

                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
