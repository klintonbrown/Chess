using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Knight : ChessPiece
    {


        public Knight(bool pieceColor) : base(pieceColor)
        {
            moveset = new int[,]
            {
                {1,2},
                {1,-2},
                {2,1},
                {2,-1},
                {-1,2},
                {-1,-2},
                {-2,1},
                {-2,-1}
            };
        }

        public override string ToString()
        {
            return "[k]";
        }
    }
}
