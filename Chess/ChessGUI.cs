using System;
using System.Windows.Forms;
using System.Drawing;

namespace Chess
{
    public partial class ChessGUI : Form
    {

        ChessMatch match;
        int selectedRow; //row number of the selected piece: 0-7
        int selectedCol; //column number of the selected piece: 0-7
        int targetRow; //row of the space the piece is to be moved to: 0-7
        int targetCol; //column of the space the piece is to be moved to: 0-7
        bool pieceSelected; //true if a piece has been selected, false otherwise

        public ChessGUI()
        {
            InitializeComponent();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            match = new ChessMatch();
            selectedRow = -1;
            selectedCol = -1;
            targetRow = -1;
            targetCol = -1;
            pieceSelected = false;
            PlayerLabel.Text = "White to move";

            BlackCapturedBox.Image = match.GenerateCapturedImage(false);
            WhiteCapturedBox.Image = match.GenerateCapturedImage(true);

            BoardImage.Image = match.GenerateBoardImage();
        }

        private void BoardImage_MouseClick(object sender, MouseEventArgs e)
        {
            int row = e.Y / 33;
            int col = e.X / 33;

            if (pieceSelected)
            {
                targetRow = row;
                targetCol = col;
                if (match.MakeMove(selectedRow, selectedCol, targetRow, targetCol))
                {
                    BoardImage.Image = match.GenerateBoardImage();
                    BlackCapturedBox.Image = match.GenerateCapturedImage(false);
                    WhiteCapturedBox.Image = match.GenerateCapturedImage(true);
                    selectedRow = -1;
                    selectedCol = -1;
                    targetRow = -1;
                    targetCol = -1;
                    pieceSelected = false;
                    if (match.CurrentPlayer) PlayerLabel.Text = "White to move";
                    else PlayerLabel.Text = "Black to move";
                }
                else
                {
                    MessageBox.Show("Choose a piece of your own color and a valid move.");
                    pieceSelected = false;
                }
            }
            else
            {
                selectedRow = row;
                selectedCol = col;
                pieceSelected = true;
            }
        }
    }
}
