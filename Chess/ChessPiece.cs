using System;
using System.Collections.Generic;
using System.Drawing;
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
        protected bool variableDistance;
        protected List<int[]> moveset;
        protected List<int[]> currentMoves;
        protected int moveCount;
        protected Bitmap pieceImage;

        public ChessPiece(bool pieceColor)
        {
            color = pieceColor;
            currentMoves = new List<int[]>();
            moveCount = 0;
        }

        public bool Color
        {
            get
            {
                return color;
            }
        }

        public bool VariableDistance
        {
            get
            {
                return variableDistance;
            }
        }

        public List<int[]> Moveset
        {
            get {
                return moveset;
            }
        }

        public List<int[]> CurrentMoves
        {
            get
            {
                return currentMoves;
            }
        }

        public int MoveCount
        {
            get
            {
                return moveCount;
            }
            set
            {
                moveCount = value;
            }
        }

        public Bitmap Image
        {
            get
            {
                return pieceImage;
            }
        }
    }
}