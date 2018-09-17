using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class King : ChessPiece
    {


        public King(bool pieceColor) : base(pieceColor)
        {
            moveset = new int[,]
            {
                {0,1},
                {0,-1},
                {1,0},
                {-1,0},
                {1,1},
                {1,-1},
                {-1,1},
                {-1,-1}
            };
        }

        public override string ToString()
        {
            return "[K]";
        }
    }
}

