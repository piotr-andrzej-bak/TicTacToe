using System;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGray;

            string[,] gameArea = new string[3, 3]
             {
                    {"1","2","3"},
                    {"4","5","6"},
                    {"7","8","9"}
             };
            
            while (true)
            {
                UserPlay(gameArea, 1);
                WinEvaluation(gameArea, 1);
                UserPlay(gameArea, 2);
                WinEvaluation(gameArea, 2);
            }
        }

        static void UserPlay(string[,] gameArea, int playerNumber)
        {
            Console.Clear();
            ShowGameArea(gameArea);
            Console.Write($"Player {playerNumber} move: ");
            string userInputString = Console.ReadLine();
            try
            {
                int userInputInt = int.Parse(userInputString);
                if (userInputInt >= 1 && userInputInt <= 9)
                {
                    FieldUpdate(gameArea, playerNumber, userInputInt);
                    Console.Clear();
                }
                else
                {
                    Console.Write("Number not in range. Press any key.");
                    Console.ReadKey();
                    Console.Clear();
                    ShowGameArea(gameArea);
                    UserPlay(gameArea, playerNumber);

                }
            }
            catch (Exception)
            {
                Console.Write("Not a number. Enter any key.");
                Console.ReadKey();
                Console.Clear();
                ShowGameArea(gameArea);
                UserPlay(gameArea, playerNumber);
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

        static string[,] FieldUpdate(string[,] gameArea, int playerNumber, int fieldNumber)
        {
            if (fieldNumber <= 9 && fieldNumber >= 1)
            {
                switch (fieldNumber)
                {
                    case 1:
                        if (playerNumber == 1)
                        {
                            if (gameArea[0, 0] == "1")
                            {
                                gameArea[0, 0] = "O";
                            }
                            else
                            {
                                Console.Write("Number already taken. Select another.");
                                Console.ReadKey();
                                Console.Clear();
                                UserPlay(gameArea, playerNumber);
                            }
                        }
                        else
                        {
                            if (gameArea[0, 0] == "1")
                            {
                                gameArea[0, 0] = "X";
                            }
                            else
                            {
                                Console.Write("Number already taken. Select another.");
                                Console.ReadKey();
                                Console.Clear();
                                UserPlay(gameArea, playerNumber);
                            }
                        }
                        return gameArea;
                    case 2:
                        if (playerNumber == 1)
                        {
                            if (gameArea[0, 1] == "2")
                            {
                                gameArea[0, 1] = "O";
                            }
                            else
                            {
                                Console.Write("Number already taken. Select another.");
                                Console.ReadKey();
                                UserPlay(gameArea, playerNumber);
                            }
                        }
                        else
                        {
                            if (gameArea[0, 1] == "2")
                            {
                                gameArea[0, 1] = "X";
                            }
                            else
                            {
                                Console.Write("Number already taken. Select another.");
                                Console.ReadKey();
                                UserPlay(gameArea, playerNumber);
                            }
                        }
                        return gameArea;
                    case 3:
                        if (playerNumber == 1)
                        {
                            if (gameArea[0, 2] == "3")
                            {
                                gameArea[0, 2] = "O";
                            }
                            else
                            {
                                Console.Write("Number already taken. Select another.");
                                Console.ReadKey();
                                UserPlay(gameArea, playerNumber);
                            }
                        }
                        else
                        {
                            if (gameArea[0, 2] == "3")
                            {
                                gameArea[0, 2] = "X";
                            }
                            else
                            {
                                Console.Write("Number already taken. Select another.");
                                Console.ReadKey();
                                UserPlay(gameArea, playerNumber);
                            }
                        }
                        return gameArea;
                    case 4:
                        if (playerNumber == 1)
                        {
                            if (gameArea[1, 0] == "4")
                            {
                                gameArea[1, 0] = "O";
                            }
                            else
                            {
                                Console.Write("Number already taken. Select another.");
                                Console.ReadKey();
                                UserPlay(gameArea, playerNumber);
                            }
                        }
                        else
                        {
                            if (gameArea[1, 0] == "4")
                            {
                                gameArea[1, 0] = "X";
                            }
                            else
                            {
                                Console.Write("Number already taken. Select another.");
                                Console.ReadKey();
                                UserPlay(gameArea, playerNumber);
                            }
                        }
                        return gameArea;
                    case 5:
                        if (playerNumber == 1)
                        {
                            if (gameArea[1, 1] == "5")
                            {
                                gameArea[1, 1] = "O";
                            }
                            else
                            {
                                Console.Write("Number already taken. Select another.");
                                Console.ReadKey();
                                UserPlay(gameArea, playerNumber);
                            }
                        }
                        else
                        {
                            if (gameArea[1, 1] == "5")
                            {
                                gameArea[1, 1] = "X";
                            }
                            else
                            {
                                Console.Write("Number already taken. Select another.");
                                Console.ReadKey();
                                UserPlay(gameArea, playerNumber);
                            }
                        }
                        return gameArea;
                    case 6:
                        if (playerNumber == 1)
                        {
                            if (gameArea[1, 2] == "6")
                            {
                                gameArea[1, 2] = "O";
                            }
                            else
                            {
                                Console.Write("Number already taken. Select another.");
                                Console.ReadKey();
                                UserPlay(gameArea, playerNumber);
                            }
                        }
                        else
                        {
                            if (gameArea[1, 2] == "6")
                            {
                                gameArea[1, 2] = "X";
                            }
                            else
                            {
                                Console.Write("Number already taken. Select another.");
                                Console.ReadKey();
                                UserPlay(gameArea, playerNumber);
                            }
                        }
                        return gameArea;
                    case 7:
                        if (playerNumber == 1)
                        {
                            if (gameArea[2, 0] == "7")
                            {
                                gameArea[2, 0] = "O";
                            }
                            else
                            {
                                Console.Write("Number already taken. Select another.");
                                Console.ReadKey();
                                UserPlay(gameArea, playerNumber);
                            }
                        }
                        else
                        {
                            if (gameArea[2, 0] == "7")
                            {
                                gameArea[2, 0] = "X";
                            }
                            else
                            {
                                Console.Write("Number already taken. Select another.");
                                Console.ReadKey();
                                UserPlay(gameArea, playerNumber);
                            }
                        }
                        return gameArea;
                    case 8:
                        if (playerNumber == 1)
                        {
                            if (gameArea[2, 1] == "8")
                            {
                                gameArea[2, 1] = "O";
                            }
                            else
                            {
                                Console.Write("Number already taken. Select another.");
                                Console.ReadKey();
                                UserPlay(gameArea, playerNumber);
                            }
                        }
                        else
                        {
                            if (gameArea[2, 1] == "8")
                            {
                                gameArea[2, 1] = "X";
                            }
                            else
                            {
                                Console.Write("Number already taken. Select another.");
                                Console.ReadKey();
                                UserPlay(gameArea, playerNumber);
                            }
                        }
                        return gameArea;
                    case 9:
                        if (playerNumber == 1)
                        {
                            if (gameArea[2, 2] == "9")
                            {
                                gameArea[2, 2] = "O";
                            }
                            else
                            {
                                Console.Write("Number already taken. Select another.");
                                Console.ReadKey();
                                UserPlay(gameArea, playerNumber);
                            }
                        }
                        else
                        {
                            if (gameArea[2, 2] == "9")
                            {
                                gameArea[2, 2] = "X";
                            }
                            else
                            {
                                Console.Write("Number already taken. Select another.");
                                Console.ReadKey();
                                UserPlay(gameArea, playerNumber);
                            }
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

        static void WinEvaluation(string[,] gameArea, int playerNumber)
        {
            if (gameArea[0, 0] == gameArea[1, 0] && gameArea[2, 0] == gameArea[1, 0] ||
                gameArea[0, 1] == gameArea[1, 1] && gameArea[2, 1] == gameArea[1, 1] ||
                gameArea[0, 2] == gameArea[1, 2] && gameArea[2, 2] == gameArea[1, 2] ||
                gameArea[0, 0] == gameArea[0, 1] && gameArea[0, 2] == gameArea[0, 1] ||
                gameArea[1, 0] == gameArea[1, 1] && gameArea[1, 2] == gameArea[1, 1] ||
                gameArea[2, 0] == gameArea[2, 1] && gameArea[2, 2] == gameArea[2, 1] ||
                gameArea[0, 0] == gameArea[1, 1] && gameArea[2, 2] == gameArea[1, 1] ||
                gameArea[0, 2] == gameArea[1, 1] && gameArea[2, 0] == gameArea[1, 1])
            {
                ShowGameArea(gameArea);
                Console.WriteLine($"PLAYER {playerNumber} IS A WINNER");
                Console.Write("Press an key to continue to reset the game.");
                Console.ReadKey();

                string[,] gameAreaNew = 
                {
                    {"1","2","3"},
                    {"4","5","6"},
                    {"7","8","9"}
                };
                for (int i = 0; i < gameArea.GetLength(0); i++)
                {
                    for (int j = 0; j < gameArea.GetLength(1); j++)
                    {
                        gameArea[i, j] = gameAreaNew[i, j];
                    }
                }
            }
        }
    }
}
