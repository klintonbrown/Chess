using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chess
{
    class Board
    {

        private ChessPiece[,] spaces;
        private ChessPlayer whitePlayer;
        private ChessPlayer blackPlayer;
        private Bitmap boardBMP;

        public Board()
        {
            spaces = new ChessPiece[8, 8];
            whitePlayer = new ChessPlayer(true);
            blackPlayer = new ChessPlayer(false);
            boardBMP = Properties.Resources.board;
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            int count = 0;

            //place white pieces on board
            foreach(ChessPiece cp in whitePlayer.PlayerPieces)
            {
                if (count < 8)
                {
                    spaces[7, count] = cp;
                }
                else
                {
                    spaces[6, count - 8] = cp;
                }
                count++;
            }

            count = 0;
            foreach (ChessPiece cp in blackPlayer.PlayerPieces)
            {
                if (count < 8)
                {
                    spaces[0, count] = cp;
                }
                else
                {
                    spaces[1, count - 8] = cp;
                }
                count++;
            }
        }

        public ChessPlayer GetPlayer(bool player)
        {
            if (player) return whitePlayer;
            else return blackPlayer;
        }

        public ChessPiece[,] Spaces
        {
            get
            {
                return spaces;
            }
        }

        public Bitmap BoardBMP
        {
            get
            {
                return boardBMP;
            }
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (spaces[i, j] != null)
                    {
                        result = result + spaces[i,j].ToString();
                    }
                    else result = result + "[   ]";
                }
                result = result + "\r\n";
            }
            return result;
        }
    }
}
