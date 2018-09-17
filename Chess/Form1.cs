using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Form1 : Form
    {

        Board gameBoard;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            gameBoard = new Board();
            richTextBox1.Text = gameBoard.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SelectPiece.TextLength > 0 && EnterMove.TextLength > 0)
            {
                gameBoard.MakeMove(SelectPiece.Text, EnterMove.Text);
                richTextBox1.Text = gameBoard.ToString();
                SelectPiece.Clear();
                EnterMove.Clear();
            }
        }
    }
}
