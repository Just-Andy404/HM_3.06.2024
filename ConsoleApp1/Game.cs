using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Game
    {
        private Board board;
        private bool isPlayerTurn;
        private Random random;

        public Game()
        {
            board = new Board();
            random = new Random();
            isPlayerTurn = random.Next(2) == 0; // Рандомно определяем, кто начинает: true - игрок, false - компьютер
        }

        public void Start()
        {
            while (true)
            {
                board.PrintBoard();
                if (isPlayerTurn)
                {
                    PlayerTurn();
                }
                else
                {
                    artificialIntelligence();
                }

                var result = board.CheckWin();
                if (result != null)
                {
                    board.PrintBoard();
                    Console.WriteLine(result);
                    break;
                }

                isPlayerTurn = !isPlayerTurn;
            }
        }

        private void PlayerTurn()
        {
            Console.WriteLine("Ваш ход. Введите номер строки и столбца (1-3):");
            int row, col;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out row) && int.TryParse(Console.ReadLine(), out col) && board.IsCellEmpty(row - 1, col - 1))
                {
                    board.SetCell(row - 1, col - 1, 'X');
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод или клетка занята! Попробуйте снова:");
                }
            }
        }

        private void artificialIntelligence()
        {
            Console.WriteLine("Ход компьютера...");
            int row, col;
            do
            {
                row = random.Next(3);
                col = random.Next(3);
            } while (!board.IsCellEmpty(row, col));
            board.SetCell(row, col, 'O');
        }
    }
}
