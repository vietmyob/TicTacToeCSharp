using System;
using TicTacToeCSharp.DTO;

namespace TicTacToeCSharp.Lib
{
    public static class ConsoleGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's start the game");
            var board = new Board();
            var humanPlayerSymbol = "O";
            var computerPlayerSymbol = "X";
            var computerPlayer = new ComputerPlayer(computerPlayerSymbol);
            var humanPlayer = new HumanPlayer(new InputChecker(), humanPlayerSymbol);
            var renderer = new BoardConsoleRenderer();
            var referee = new WinnerReferee();

            computerPlayer.Move(board, 4);
            Console.WriteLine(renderer.Render(board));
            var winner = string.Empty;

            while (string.IsNullOrEmpty(winner))
            {
                var humanMove = Console.ReadLine();
                humanPlayer.Move(board, int.Parse(humanMove));
                winner = referee.CheckWinner(board, humanPlayerSymbol);
                Console.WriteLine(renderer.Render(board));
                AnnounceWinner(winner);
                if(!string.IsNullOrEmpty(winner)) break;

                var computerMove = computerPlayer.Solve(board, humanPlayerSymbol);
                computerPlayer.Move(board, computerMove);
                winner = referee.CheckWinner(board, computerPlayerSymbol);
                Console.WriteLine(renderer.Render(board));
                AnnounceWinner(winner);
                if (!string.IsNullOrEmpty(winner)) break;
            }

            if (string.IsNullOrEmpty(winner))
            {
                Console.WriteLine("It's a draw");
            }

            Console.ReadKey();
        }

        private static void AnnounceWinner(string winner)
        {
            if (!string.IsNullOrEmpty(winner))
            {
                Console.WriteLine($"{winner} has won the game");
            }
        }
    }
}