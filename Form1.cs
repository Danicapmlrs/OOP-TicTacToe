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
        public TicTacToe_Game()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text="X";
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == HelpMenu)
            {
                MessageBox.Show("Instructions");
            }
            else if (e.ClickedItem == AboutMenu)
            {
                MessageBox.Show("The Program is about");
            }
               
        }

        private void ExitDrop_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
