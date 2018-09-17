using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Rook : ChessPiece
    {


        public Rook(bool pieceColor) : base(pieceColor)
        {
            moveset = new int[,]
            {
                {0,7},
                {0,-7},
                {7,0},
                {-7,0}
            };
        }

        public override string ToString()
        {
            return "[R]";
        }
    }
}
