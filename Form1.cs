using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_TicTacToe
{
    public partial class TicTacToe_Game : Form
    {
        bool Player_Turn = true;
        public TicTacToe_Game()
        {
            InitializeComponent();
        }
        private void Winner()
        {
            bool is_winner = false;


        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (Player_Turn == true)
            {
                b.Text="X";
                b.Enabled = false;
            }
            else
            {
                b.Text = "O";
                b.Enabled = false;
            }
            Player_Turn = !Player_Turn;

            Winner();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == HelpMenu)
            {
                MessageBox.Show("Like an ordinary Tic Tac Toe or Noughts and Crosses, the players will alternately" +
                    " place O and X on the squares by clicking the buttons, until the row is completed vertically" +
                    ",horizontally or diagonally by a player. If a player succesfully draw straight X or O in a row," +
                    " then that player wins. You may press, File->New Game, to start a new game. Press Exit to exit the game.","Help");
            }
            else if (e.ClickedItem == AboutMenu)
            {
                MessageBox.Show("Tic Tac Toe, Noughts and Crosses, Xs and Os." +
                    "A free game, child-friendly and enjoyable game you can access anytime." +
                    " This game is created and programmed by Danica G. Pamoleras.","About");
            }
               
        }

        private void ExitDrop_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
