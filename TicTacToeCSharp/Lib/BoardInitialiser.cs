using System;
using System.Linq;

namespace TicTacToeCSharp.Lib
{
    public class BoardInitialiser
    {
        public string[] Create()
        {
            return Enumerable.Repeat("", 9).ToArray();
        }
    }
}