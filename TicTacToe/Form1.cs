using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        BoardChecker game = new BoardChecker();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Call clear method
            game.Clear();

            //Clear each picture image
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;

            //Update texts
            textBox1.Text = Convert.ToString(game.turn);
            textBox2.Text = game.displayWinner;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Call clear method
            game.Clear();

            //Completely reset remaining values
            game.XWins = 0;
            game.OWins = 0;
            game.totalGames = 0;

            //Clear each picture image
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;

            //Update texts
            textBox1.Text = Convert.ToString(game.turn);
            textBox2.Text = game.displayWinner;
            label2.Text = " ";
            label3.Text = " ";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Check that there is no winner and that this space is empty
            if (game.winner == false && game.board[0] == ' ')
            {
                //Update the png on the pictureBox. If there is an error, it is displayed in textBox1
                try
                {
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\" + game.turn + ".png");
                }
                catch
                {
                    textBox1.Text = "Error.";
                }

                //Accumulate move to game object
                game.Accumulate(0, game.turn);

                //Update player turn
                textBox1.Text = Convert.ToString(game.turn);
            }   
            
            //Check to see if there is a winner
            if (game.winner == true)
            {
                //Update textBox2 to display winner
                textBox2.Text = game.displayWinner;

                //Update "Records"
                label2.Text = game.XRecord;
                label3.Text = game.ORecord;
            } 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Check that there is no winner and that this space is empty
            if (game.winner == false && game.board[1] == ' ')
            {
                //Update the png on the pictureBox. If there is an error, it is displayed in textBox1
                try
                {
                    pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\" + game.turn + ".png");
                }
                catch
                {
                    textBox1.Text = "Error.";
                }

                //Accumulate move to game object
                game.Accumulate(1, game.turn);

                //Update player turn
                textBox1.Text = Convert.ToString(game.turn);
            }

            //Check to see if there is a winner
            if (game.winner == true)
            {
                //Update textBox2 to display winner
                textBox2.Text = game.displayWinner;

                //Update "Records"
                label2.Text = game.XRecord;
                label3.Text = game.ORecord;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Check that there is no winner and that this space is empty
            if (game.winner == false && game.board[2] == ' ')
            {
                //Update the png on the pictureBox. If there is an error, it is displayed in textBox1
                try
                {
                    pictureBox3.Image = Image.FromFile(Application.StartupPath + "\\" + game.turn + ".png");
                }
                catch
                {
                    textBox1.Text = "Error.";
                }

                //Accumulate move to game object
                game.Accumulate(2, game.turn);

                //Update player turn
                textBox1.Text = Convert.ToString(game.turn);
            }

            //Check to see if there is a winner
            if (game.winner == true)
            {
                //Update textBox2 to display winner
                textBox2.Text = game.displayWinner;

                //Update "Records"
                label2.Text = game.XRecord;
                label3.Text = game.ORecord;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Check that there is no winner and that this space is empty
            if (game.winner == false && game.board[3] == ' ')
            {
                //Update the png on the pictureBox. If there is an error, it is displayed in textBox1
                try
                {
                    pictureBox4.Image = Image.FromFile(Application.StartupPath + "\\" + game.turn + ".png");
                }
                catch
                {
                    textBox1.Text = "Error.";
                }

                //Accumulate move to game object
                game.Accumulate(3, game.turn);

                //Update player turn
                textBox1.Text = Convert.ToString(game.turn);
            }

            //Check to see if there is a winner
            if (game.winner == true)
            {
                //Update textBox2 to display winner
                textBox2.Text = game.displayWinner;

                //Update "Records"
                label2.Text = game.XRecord;
                label3.Text = game.ORecord;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //Check that there is no winner and that this space is empty
            if (game.winner == false && game.board[4] == ' ')
            {
                //Update the png on the pictureBox. If there is an error, it is displayed in textBox1
                try
                {
                    pictureBox5.Image = Image.FromFile(Application.StartupPath + "\\" + game.turn + ".png");
                }
                catch
                {
                    textBox1.Text = "Error.";
                }

                //Accumulate move to game object
                game.Accumulate(4, game.turn);

                //Update player turn
                textBox1.Text = Convert.ToString(game.turn);
            }

            //Check to see if there is a winner
            if (game.winner == true)
            {
                //Update textBox2 to display winner
                textBox2.Text = game.displayWinner;

                //Update "Records"
                label2.Text = game.XRecord;
                label3.Text = game.ORecord;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //Check that there is no winner and that this space is empty
            if (game.winner == false && game.board[5] == ' ')
            {
                //Update the png on the pictureBox. If there is an error, it is displayed in textBox1
                try
                {
                    pictureBox6.Image = Image.FromFile(Application.StartupPath + "\\" + game.turn + ".png");
                }
                catch
                {
                    textBox1.Text = "Error.";
                }

                //Accumulate move to game object
                game.Accumulate(5, game.turn);

                //Update player turn
                textBox1.Text = Convert.ToString(game.turn);
            }

            //Check to see if there is a winner
            if (game.winner == true)
            {
                //Update textBox2 to display winner
                textBox2.Text = game.displayWinner;

                //Update "Records"
                label2.Text = game.XRecord;
                label3.Text = game.ORecord;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //Check that there is no winner and that this space is empty
            if (game.winner == false && game.board[6] == ' ')
            {
                //Update the png on the pictureBox. If there is an error, it is displayed in textBox1
                try
                {
                    pictureBox7.Image = Image.FromFile(Application.StartupPath + "\\" + game.turn + ".png");
                }
                catch
                {
                    textBox1.Text = "Error.";
                }

                //Accumulate move to game object
                game.Accumulate(6, game.turn);

                //Update player turn
                textBox1.Text = Convert.ToString(game.turn);
            }

            //Check to see if there is a winner
            if (game.winner == true)
            {
                //Update textBox2 to display winner
                textBox2.Text = game.displayWinner;

                //Update "Records"
                label2.Text = game.XRecord;
                label3.Text = game.ORecord;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //Check that there is no winner and that this space is empty
            if (game.winner == false && game.board[7] == ' ')
            {
                //Update the png on the pictureBox. If there is an error, it is displayed in textBox1
                try
                {
                    pictureBox8.Image = Image.FromFile(Application.StartupPath + "\\" + game.turn + ".png");
                }
                catch
                {
                    textBox1.Text = "Error.";
                }

                //Accumulate move to game object
                game.Accumulate(7, game.turn);

                //Update player turn
                textBox1.Text = Convert.ToString(game.turn);
            }

            //Check to see if there is a winner
            if (game.winner == true)
            {
                //Update textBox2 to display winner
                textBox2.Text = game.displayWinner;

                //Update "Records"
                label2.Text = game.XRecord;
                label3.Text = game.ORecord;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //Check that there is no winner and that this space is empty
            if (game.winner == false && game.board[8] == ' ')
            {
                //Update the png on the pictureBox. If there is an error, it is displayed in textBox1
                try
                {
                    pictureBox9.Image = Image.FromFile(Application.StartupPath + "\\" + game.turn + ".png");
                }
                catch
                {
                    textBox1.Text = "Error.";
                }

                //Accumulate move to game object
                game.Accumulate(8, game.turn);

                //Update player turn
                textBox1.Text = Convert.ToString(game.turn);
            }

            //Check to see if there is a winner
            if (game.winner == true)
            {
                //Update textBox2 to display winner
                textBox2.Text = game.displayWinner;

                //Update "Records"
                label2.Text = game.XRecord;
                label3.Text = game.ORecord;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
