using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Pawn : ChessPiece
    {


        public Pawn(bool pieceColor) : base(pieceColor)
        {
            if (pieceColor)
            {
                moveset = new int[,]
                {
                    {-1,0},
                    {-2,0},
                    //attacking
                    {-1,1 },
                    {-1,-1 }
                };
            }
            else
            {
                moveset = new int[,]
                {
                    {1,0},
                    {2,0},
                    //attacking
                    {1,1 },
                    {1,-1 }
                };
            }
        }

        public override string ToString()
        {
            return "[P]";
        }
    }
}
