using System;
using System.Linq;
using TicTacToeCSharp.DTO;

namespace TicTacToeCSharp.Lib
{
    public static class ConsoleGame
    {
        static void Main()
        {
            Play();
        }

        private static void Play()
        {
            Console.WriteLine("Let's start the game");
            var board = new Board();
            const string humanPlayerSymbol = "O";
            const string computerPlayerSymbol = "X";
            var computerPlayer = new ComputerPlayer(computerPlayerSymbol);
            var humanPlayer = new HumanPlayer(new InputChecker(), humanPlayerSymbol);
            var renderer = new BoardConsoleRenderer();
            var referee = new WinnerReferee();

            computerPlayer.Move(board, 4);
            Console.WriteLine(renderer.Render(board));
            var winner = string.Empty;

            while (string.IsNullOrEmpty(winner))
            {
                Console.WriteLine("Your turn:");
                var humanMove = Console.ReadLine();
                humanPlayer.Move(board, int.Parse(humanMove));
                winner = referee.CheckWinner(board, humanPlayerSymbol);
                Console.WriteLine(renderer.Render(board));
                AnnounceWinner(winner);
                if (!string.IsNullOrEmpty(winner)) break;
                if (board.Squares.All(x => !string.IsNullOrEmpty(x))) break;

                var computerMove = computerPlayer.Solve(board, humanPlayerSymbol);
                computerPlayer.Move(board, computerMove);
                winner = referee.CheckWinner(board, computerPlayerSymbol);
                Console.WriteLine(renderer.Render(board));
                AnnounceWinner(winner);
                if (!string.IsNullOrEmpty(winner)) break;
                if (board.Squares.All(x => !string.IsNullOrEmpty(x))) break;
            }

            if (string.IsNullOrEmpty(winner))
            {
                Console.WriteLine("It's a draw");
            }

            Console.WriteLine("Replay? (Y or N)");
            var reply = Console.ReadLine();
            if(reply?.ToUpper() == "Y")
                Play();

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