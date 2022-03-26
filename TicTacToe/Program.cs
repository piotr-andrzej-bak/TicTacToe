using System;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();

            string[,] gameArea = new string[3, 3]
             {
                    {"1","2","3"},
                    {"4","5","6"},
                    {"7","8","9"}
             };
            //petla glowna
            while (true)
            {
                ShowGameArea(gameArea);
                userPlay(gameArea, 1);
                ShowGameArea(gameArea);
                userPlay(gameArea, 2);
            }
        }

        static void userPlay(string[,] gameArea, int playerNumber)
        {
            Console.Write($"Player {playerNumber} move: ");
            string userInputString = Console.ReadLine();
            try
            {
                int userInputInt = int.Parse(userInputString);
                if (userInputInt >= 1 && userInputInt <= 9)
                {
                    fieldUpdate(gameArea, playerNumber, userInputInt);
                    Console.Clear();
                }
                else
                {
                    Console.Write("Number not in range. Press any key.");
                    Console.ReadKey();
                    Console.Clear();
                    ShowGameArea(gameArea);
                    userPlay(gameArea, playerNumber);

                }
            }
            catch (Exception)
            {
                Console.Write("Not a number. Enter any key.");
                Console.ReadKey();
                Console.Clear();
                ShowGameArea(gameArea);
                userPlay(gameArea, playerNumber);
            }
        }

        static void ShowGameArea(string[,] gameArea)
        {
            for (int i = 0; i < gameArea.GetLength(0); i++)
            {
                for (int j = 0; j < gameArea.GetLength(1); j++)
                {
                    Console.Write($"  {gameArea[i, j]}  ");
                }
                Console.WriteLine();
            }
        }

        static string[,] fieldUpdate(string[,] gameArea, int playerNumber, int fieldNumber)
        {
            if (fieldNumber <= 9 && fieldNumber >= 1)
            {
                switch (fieldNumber)
                {
                    case 1:
                        if (playerNumber == 1)
                        {
                            gameArea[0, 0] = "O";
                        }
                        else
                        {
                            gameArea[0, 0] = "X";
                        }
                        return gameArea;
                    case 2:
                        if (playerNumber == 1)
                        {
                            gameArea[0, 1] = "O";
                        }
                        else
                        {
                            gameArea[0, 1] = "X";
                        }
                        return gameArea;
                    case 3:
                        if (playerNumber == 1)
                        {
                            gameArea[0, 2] = "O";
                        }
                        else
                        {
                            gameArea[0, 2] = "X";
                        }
                        return gameArea;
                    case 4:
                        if (playerNumber == 1)
                        {
                            gameArea[1, 0] = "O";
                        }
                        else
                        {
                            gameArea[1, 0] = "X";
                        }
                        return gameArea;
                    case 5:
                        if (playerNumber == 1)
                        {
                            gameArea[1, 1] = "O";
                        }
                        else
                        {
                            gameArea[1, 1] = "X";
                        }
                        return gameArea;
                    case 6:
                        if (playerNumber == 1)
                        {
                            gameArea[1, 2] = "O";
                        }
                        else
                        {
                            gameArea[1, 2] = "X";
                        }
                        return gameArea;
                    case 7:
                        if (playerNumber == 1)
                        {
                            gameArea[2, 0] = "O";
                        }
                        else
                        {
                            gameArea[2, 0] = "X";
                        }
                        return gameArea;
                    case 8:
                        if (playerNumber == 1)
                        {
                            gameArea[2, 1] = "O";
                        }
                        else
                        {
                            gameArea[2, 1] = "X";
                        }
                        return gameArea;
                    case 9:
                        if (playerNumber == 1)
                        {
                            gameArea[2, 2] = "O";
                        }
                        else
                        {
                            gameArea[2, 2] = "X";
                        }
                        return gameArea;
                    default:
                        Console.WriteLine("Wrong number");
                        return gameArea;
                }
            }
            else
            {
                return gameArea;
            }
        }

        static void WinEvaluation(int playerNumber)
        {
            //8 kombinacji do wygranej
            //wejscie to numer gracza
            //wyjscie to bool z info czy wygral czy nie

        }



    }
}
