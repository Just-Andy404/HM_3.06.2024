using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Board
    {
        private char[,] cells = new char[3, 3];

        public Board()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    cells[i, j] = ' ';
        }

        public void PrintBoard()
        {
            // Вывод заголовков для столбцов
            Console.WriteLine("   | 1 | 2 | 3 |");
            // Перебор строк
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("================");
                Console.Write($" {i + 1} |");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {cells[i, j]} |");
                    
                }
                Console.WriteLine();

            }
        }

        public bool IsCellEmpty(int row, int col)
        {
            return cells[row, col] == ' ';
        }

        public void SetCell(int row, int col, char player)
        {
            cells[row, col] = player;
        }

        public string CheckWin()
        {
            // Проверяем строки, столбцы и диагонали
            for (int i = 0; i < 3; i++)
            {
                if (cells[i, 0] == cells[i, 1] && cells[i, 1] == cells[i, 2] && cells[i, 0] != ' ')
                    return $"Победили {cells[i, 0]}!";
                if (cells[0, i] == cells[1, i] && cells[1, i] == cells[2, i] && cells[0, i] != ' ')
                    return $"Победили {cells[0, i]}!";
            }

            if (cells[0, 0] == cells[1, 1] && cells[1, 1] == cells[2, 2] && cells[0, 0] != ' ')
                return $"Победили {cells[0, 0]}!";
            if (cells[0, 2] == cells[1, 1] && cells[1, 1] == cells[2, 0] && cells[0, 2] != ' ')
                return $"Победили {cells[0, 2]}!";

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (cells[i, j] == ' ')
                        return null; 

            return "Ничья!";
        }
    }
}
