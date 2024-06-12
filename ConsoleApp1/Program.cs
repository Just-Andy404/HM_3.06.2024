using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создайте приложение "Крестики-Нулики". Пользователь играет
//с компьютером. При старте игры рандомно выбирается, кто
//первым начинает игру. Игроки ходят по очереди. Игра может закончиться
//закончиться победой одного из игроков или ничьей. Используйте механизмы пространств имен.

namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();
        }
    }
}
