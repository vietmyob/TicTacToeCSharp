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
            return _winnerLines.Any(winnerLine => !winnerLine.Except(indexesOfUserInputs).Any())
                ? playerSymbol
                : string.Empty;
        }
    }
}