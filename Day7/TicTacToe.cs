using System;

namespace TicTacToe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //laukums, divdimensiju masivs, 3x3 
            FieldEnum[,] board = GetEmptyBoard();
            FieldEnum currentPlayer = FieldEnum.X;
            bool isGameFinished = false;
            //drukāsim laukumu 
            Console.WriteLine("Game begins, it's X turn!");
            PrintBoard(board);
            //Katrā cikla iterācijā kāds spēlētājs veic gājienu  
            do
            {
                Console.WriteLine();
                Console.Write("Please enter row number:");
                string row = Console.ReadLine();
                Console.Write("Please enter column number:");
                string col = Console.ReadLine();
                //Ierakstot STOP rindas vai kolonas ievadē, programma/cikls apstājas 
                if (row == "STOP" || col == "STOP")
                {
                    break;
                }
                //Vai ievadītās vērtības nav tukšas. Ja ir, tad kļūda un cikls no jauna 
                if (string.IsNullOrEmpty(row) || string.IsNullOrEmpty(col))
                {
                    Console.WriteLine("Please enter non-empty value!");
                    continue;
                }
                //Mēģinām pārveidot ievadītās vērtības par rindas un kolonas skaitļiem 
                int rowNum;
                int colNum;
                bool rowSuccess = int.TryParse(row, out rowNum);
                bool colSuccess = int.TryParse(col, out colNum);
                //Pārbaudām, vai kādu ievadīto nevarēja pārveidot par skaitli 
                if (!rowSuccess || !colSuccess)
                {
                    Console.WriteLine("Please enter number type values!");
                    continue;
                }
                //Ievadītās laukuma koordinātas nevar būt ārpus diapazona 1-3 
                if (rowNum < 1 || rowNum > 3 || colNum < 1 || colNum > 3)
                {
                    Console.WriteLine("Please enter number values in range 1-3!");
                    continue;
                }
                //Nevar veikt gājienu ne-tukšā lauciņā  
                if (board[rowNum - 1, colNum - 1] != FieldEnum.Empty)
                {
                    Console.WriteLine("Please make a move in an empty space!");
                    continue;
                }
                board[rowNum - 1, colNum - 1] = currentPlayer;
                PrintBoard(board);
                currentPlayer = currentPlayer == FieldEnum.X ? FieldEnum.O : FieldEnum.X;
                isGameFinished = GameFinished(board);
            } while (!isGameFinished);
        }

        private static bool GameFinished(FieldEnum[,] board)
        {
            //pārbauda rindas
            for (int i = 0; i <board.GetLength(0); i++)
            {
                if (board[i,0] != FieldEnum.Empty && board[i,0] == board[i, 1] &&
                                                    board[i,1] == board[i,2])
                {
                    Console.WriteLine($"Uzvarētājs ir {board[i, 0]}");
                    return true;

                }         
                
            }

            //pārbauda kolonnas
            for (int i = 0; i < board.GetLength(1); i++)
            {
                if (board[0, i] != FieldEnum.Empty && board[0,i] == board[1,i] &&
                                                    board[1,i] == board[2,i])
                {
                    Console.WriteLine($"Uzvarētājs ir {board[0,i]}");
                    return true;
                }

            }

            //pārbauda diagonāles
            if (board[0, 0] != FieldEnum.Empty && board[0,0] == board[1,1] && board[1, 1] == board[2,2])
            {
                Console.WriteLine($"Uzvarētājs ir {board[0, 0]}");
                return true;
            }

            if (board[0, 2] != FieldEnum.Empty && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                Console.WriteLine($"Uzvarētājs ir {board[0, 2]}");
                return true;
            }

            //pārbauda vai spēle beigusies (visi lauki aizpildīti)
            for (int r = 0; r < board.GetLength(0); r++)
            {
                for (int k = 0; k < board.GetLength(0); k++)
                {
                    if (board[r,k] == FieldEnum.Empty)
                    {
                        return false;
                    }
                }
            }

            Console.WriteLine("Neizšķirts!");
            return true;            
        }

        private static void PrintBoard(FieldEnum[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    switch (board[i, j])
                    {
                        case FieldEnum.O:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("O ");
                            break;
                        case FieldEnum.X:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("X ");
                            break;
                        case FieldEnum.Empty:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("_ "); break;
                        default:
                            break;
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        private static FieldEnum[,] GetEmptyBoard()
        {
            FieldEnum[,] board = new FieldEnum[3, 3];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = FieldEnum.Empty;
                }
            }
            return board;
        }
    }
}
