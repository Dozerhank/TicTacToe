using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class BoardChecker
    {
        //Game board
        public char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public int[,] checkWin = { { 0,1,2 }, { 3,4,5 }, { 6,7,8 }, { 0,3,6 }, { 1,4,7 }, { 2,5,8 }, { 0,4,8 }, { 2,4,6 } };
        public char turn = 'X';

        //Previous game variables
        public bool winner = false;
        public string displayWinner = " ";
        public double XWins, OWins, totalGames = 0;
        public string XRecord, ORecord = " ";


        public void Accumulate(int i, char s)
        {
            //Update board space to the right char
            board[i] = s;

            //Update the game turn
            if (this.turn == 'X')
            {
                this.turn = 'O';
            }
            else
            {
                this.turn = 'X';
            }

            //Check for a winner
            if (this.Xwin() == true || this.Owin() == true || this.Tie() == true)
            {
                this.winner = true;
            }
        }

        public void Clear()
        {
            //Reset values
            this.winner = false;
            this.turn = 'X';
            this.displayWinner = " ";

            //Reset board
            for (int i = 0; i < 9; i++)
            {
                this.board[i] = ' ';
            }
        }

        public bool Xwin()
        {
            //Create tempory bool to hold winner status
            bool tempWinner = false;

            //Check each row of matrix checkWin[,] against board[]
            for (int i = 0; i < 8; i++)
            {
                if (board[checkWin[i,0]] == 'X' && board[checkWin[i,1]] == 'X' && board[checkWin[i,2]] == 'X')
                {
                    tempWinner = true;
                    break;
                }
            }

            //Update X win stats
            if (tempWinner == true)
            {
                this.displayWinner = "X wins!";
                this.XWins++;
                this.totalGames++;

                //Update record strings
                this.XRecord = "X wining: " + Convert.ToString((this.XWins / this.totalGames).ToString("F2"));
                this.ORecord = "O wining: " + Convert.ToString((this.OWins / this.totalGames).ToString("F2"));
            }

            //Return if there is a winner
            return tempWinner;
        }

        public bool Owin()
        {
            //Create tempory bool to hold winner status
            bool tempWinner = false;

            //Check each row of matrix checkWin[,] against board[]
            for (int i = 0; i < 8; i++)
            {
                if (board[checkWin[i, 0]] == 'O' && board[checkWin[i, 1]] == 'O' && board[checkWin[i, 2]] == 'O')
                {
                    tempWinner = true;
                    break;
                }
            }

            //Update O win stats
            if (tempWinner == true)
            {
                this.displayWinner = "O wins!";
                this.OWins++;
                this.totalGames++;

                //Update record strings
                this.ORecord = "O wining: " + Convert.ToString((this.OWins / this.totalGames).ToString("F2"));
                this.XRecord = "X wining: " + Convert.ToString((this.XWins / this.totalGames).ToString("F2"));
            }

            //Return if there is a winner
            return tempWinner;
        }

        public bool Tie()
        {
            //Create tempory bool to hold winner status 
            bool tempWinner = true;

            //Check for empty spaces in board
            for (int i = 0; i < 9; i++)
            {
                if (board[i] == ' ')
                {
                    tempWinner = false;
                }
            }

            //Update Tie game stats
            if (tempWinner == true)
            {
                this.displayWinner = "Tie game!";
                this.totalGames++;

                //Update record strings
                try
                {
                    this.XRecord = "X wining: " + Convert.ToString((this.XWins / this.totalGames).ToString("F2"));
                }
                catch
                {
                    this.XRecord = "X wining: 0.00";
                }
                try
                {
                    this.ORecord = "O wining: " + Convert.ToString((this.OWins / this.totalGames).ToString("F2"));
                }
                catch
                {
                    this.ORecord = "O wining: 0.00";
                }
            }

            //Return if there is a winner
            return tempWinner;
        }
    }
}