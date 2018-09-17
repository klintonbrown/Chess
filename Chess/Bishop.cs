using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Bishop : ChessPiece
    {


        public Bishop(bool pieceColor) : base(pieceColor)
        {
            moveset = new int[,]
            {
                {7,7},
                {7,-7},
                {-7,7},
                {-7,-7}
            };
        }

        public override string ToString()
        {
            return "[B]";
        }
    }
}
