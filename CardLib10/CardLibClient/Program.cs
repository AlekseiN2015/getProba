using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KerliCards - новая и увлекательная карточная игра!");
            Console.WriteLine("Для выгрыша необходимо, чтобы на руках было семь карт одной масти!");
            Console.WriteLine();
            //Отображение приглашения ввести колличество играков
            bool inputOk = false;
            int choise = -1;
            do
            {
                Console.WriteLine("Введите количество играков (от 2 до 7) :");
                string input = Console.ReadLine();
                try
                {
                    //попытка преобразовать в число введённые данные
                    choise = Convert.ToInt32(input);
                    if ((choise >= 2) && (choise <= 7))
                        inputOk = true;
                }
                catch
                {
                    //игнорирование неудачных попыток

                }
            } while (inputOk == false);

            //инициализация массива играков
            Player[] players = new Player[choise];

            //инициализация имён играков
            for(int p = 0; p < players.Length; p++)
            {
                Console.WriteLine("Игрок {0}, введите своё имя!", p + 1);
                string playerName = Console.ReadLine();
                players[p] = new Player(playerName);
            }

            //запуск игры
            Game newGame = new Game();
            newGame.SetPlayers(players);
            int whoWon = newGame.PlayGame();

            //отображение побидителя игры
            Console.WriteLine("{0} виыграл!", players[whoWon].Name);
            
        }
    }
}
