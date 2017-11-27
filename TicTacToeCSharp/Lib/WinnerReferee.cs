using System;
using System.Collections.Generic;
using System.Linq;
using TicTacToeCSharp.DTO;

namespace TicTacToeCSharp.Lib
{
    public class WinnerReferee
    {
        private readonly BoardAnalyser _boardAnalyser;
        private readonly List<List<int>> _winnerLines;

        public WinnerReferee()
        {
            _boardAnalyser = new BoardAnalyser();
            _winnerLines = new Config().WinnerLines;
        }

        public string CheckWinner(Board board, string playerSymbol)
        {
            var indexesOfUserInputs = _boardAnalyser.GetAllIndexesOfPlayerInput(board, playerSymbol);
            return UserInputsMatchWinnerLine(indexesOfUserInputs)
                ? playerSymbol
                : string.Empty;
        }

        private bool UserInputsMatchWinnerLine(List<int> indexesOfUserInputs)
        {
            return _winnerLines.Any(winnerLine => !winnerLine.Except(indexesOfUserInputs).Any());
        }

        public void AnnounceDrawIfNoWinner(string winner)
        {
            if (string.IsNullOrEmpty(winner))
            {
                Console.WriteLine("It's a draw");
            }
        }

        public void AnnounceWinner(string winner)
        {
            if (!string.IsNullOrEmpty(winner))
            {
                Console.WriteLine($"{winner} has won the game");
            }
        }
    }
}