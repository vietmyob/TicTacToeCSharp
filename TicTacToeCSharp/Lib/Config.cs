using System.Collections.Generic;

namespace TicTacToeCSharp.Lib
{
    public static class Config
    {
        public static readonly List<List<int>> WinnerLines = new List<List<int>>
        {
            new List<int>() {0, 1, 2},
            new List<int>() {3, 4, 5},
            new List<int>() {6, 7, 8},
            new List<int>() {0, 3, 6},
            new List<int>() {1, 4, 7},
            new List<int>() {2, 5, 8},
            new List<int>() {0, 4, 8},
            new List<int>() {2, 4, 6},
        };
    }
}