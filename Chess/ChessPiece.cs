using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class ChessPiece
    {

        /* The color of a piece is represented by a bool.
         True is white; False is black. */
        protected bool color;
        protected int[,] moveset;

        public ChessPiece(bool pieceColor)
        {
            color = pieceColor;
        }

        public bool Color
        {
            get
            {
                return color;
            }
        }

        public int[,] Moveset
        {
            get {
                return moveset;
            }
        }
    }
}