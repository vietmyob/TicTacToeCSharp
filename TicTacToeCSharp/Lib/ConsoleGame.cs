using System;
using System.Linq;
using TicTacToeCSharp.DTO;

namespace TicTacToeCSharp.Lib
{
    public static class ConsoleGame
    {
        static void Main()
        {
            Execute();
        }

        private static void Execute()
        {
            Console.WriteLine("Let's start the game");

            SetUpBoardAndSymbols(out var board, out var humanPlayerSymbol, out var computerPlayerSymbol);
            SetUpPlayers(humanPlayerSymbol, computerPlayerSymbol, out var computerPlayer, out var humanPlayer);
            SetUpEngine(out var renderer, out var referee);

            computerPlayer.Move(board, 4);
            Console.WriteLine(renderer.Render(board));
            var winner = Play(board, humanPlayerSymbol, computerPlayerSymbol, computerPlayer, humanPlayer, renderer, referee);

            referee.AnnounceDrawIfNoWinner(winner);

            AllowReplay();
        }

        private static string Play(Board board, string humanPlayerSymbol, string computerPlayerSymbol, ComputerPlayer computerPlayer, HumanPlayer humanPlayer, BoardConsoleRenderer renderer, WinnerReferee referee)
        {
            var winner = string.Empty;
            while (string.IsNullOrEmpty(winner))
            {
                Console.WriteLine("Your turn:");
                var humanMove = Console.ReadLine();
                humanPlayer.Move(board, int.Parse(humanMove));
                Console.WriteLine(renderer.Render(board));
                winner = referee.CheckWinner(board, humanPlayerSymbol);
                referee.AnnounceWinner(winner);
                if (!string.IsNullOrEmpty(winner)) break;
                if (board.Squares.All(x => !string.IsNullOrEmpty(x))) break;

                var computerMove = computerPlayer.Solve(board, humanPlayerSymbol);
                computerPlayer.Move(board, computerMove);
                Console.WriteLine(renderer.Render(board));
                winner = referee.CheckWinner(board, computerPlayerSymbol);
                referee.AnnounceWinner(winner);
                if (!string.IsNullOrEmpty(winner)) break;
                if (board.Squares.All(x => !string.IsNullOrEmpty(x))) break;
            }

            return winner;
        }

        private static void SetUpEngine(out BoardConsoleRenderer renderer, out WinnerReferee referee)
        {
            renderer = new BoardConsoleRenderer();
            referee = new WinnerReferee();
        }

        private static void SetUpPlayers(string humanPlayerSymbol, string computerPlayerSymbol, out ComputerPlayer computerPlayer, out HumanPlayer humanPlayer)
        {
            computerPlayer = new ComputerPlayer(computerPlayerSymbol);
            humanPlayer = new HumanPlayer(new InputChecker(), humanPlayerSymbol);
        }

        private static void SetUpBoardAndSymbols(out Board board, out string humanPlayerSymbol, out string computerPlayerSymbol)
        {
            board = new Board(3);
            humanPlayerSymbol = "O";
            computerPlayerSymbol = "X";
        }

        private static void AllowReplay()
        {
            Console.WriteLine("Replay? (Y or N)");
            var reply = Console.ReadLine();
            if (reply?.ToUpper() == "Y")
                Execute();

            Console.ReadKey();
        }
    }
}