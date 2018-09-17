using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Queen : ChessPiece
    {


        public Queen(bool pieceColor) : base (pieceColor)
        {
            moveset = new int[,]
            {
                {0,7},
                {0,-7},
                {7,0},
                {-7,0},
                {7,7},
                {7,-7},
                {-7,7},
                {-7,-7}
            };
        }

        public override string ToString()
        {
            return "[Q]";
        }
    }
}
