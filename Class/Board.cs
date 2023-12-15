using System;
using System.Collections.Generic;
using System.Text;

namespace kolkoikrzyzyk.Class
{
    class Board
    {
        private int size;
        private char[,] boardArray;
        private int positionX;
        private int positionY;
        public bool xTurn;

        public Board(int size)
        {
            this.size = size;
            boardArray = new char[(size * 2) - 1, (size * 2) - 1];
            FillBoard();
        }

        private void FillBoard()
        {
            for (int i = 0; i < ((size * 2) - 1); i++)
            {
                for (int j = 0; j < ((size * 2) - 1); j++)
                {
                    if (i % 2 == 1 && j % 2 == 1)
                    {
                        boardArray[i, j] = '+';
                    }
                    else if (i % 2 == 1) { boardArray[i, j] = '_'; }
                    else if (j % 2 == 1) { boardArray[i, j] = '|'; }
                    else { boardArray[i, j] = ' '; }
                }
            }
        }

        public void ReadPlayerMovement()
        {
            var key = Console.ReadKey().Key;
            switch (key)
            {

                case ConsoleKey.DownArrow:
                    positionY += 2;
                    break;
                case ConsoleKey.UpArrow:
                    positionY -= 2;
                    break;
                case ConsoleKey.LeftArrow:
                    positionX -= 2;
                    break;
                case ConsoleKey.RightArrow:
                    positionX += 2;
                    break;
                case ConsoleKey.Escape:

                    Environment.Exit(0);
                    break;
                case ConsoleKey.Enter:
                    SetPlayerChar();
                    break;
            }
        }

        public void SetPlayerChar()
        {

            xTurn = !xTurn;
            if (xTurn)
            {
                boardArray[positionY, positionX] = 'X';
            }

            else
            {
                boardArray[positionY, positionX] = 'o';
            }
        }

        public void DrawBoard()
        {
            for (int i = 0; i < ((size * 2) - 1); i++)
            {
                for (int j = 0; j < ((size * 2) - 1); j++)
                {
                    if (i == positionY && j == positionX)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }

                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.Write(boardArray[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
