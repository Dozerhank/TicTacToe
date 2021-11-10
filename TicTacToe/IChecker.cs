using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public interface IChecker
    {
        void Accumulate(int i, char s);
        void Clear();
        bool Xwin();
        bool Owin();
        bool Tie();
    }
}
