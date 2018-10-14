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
            variableDistance = false;

            if (color)
            {
                pieceImage = Chess.Properties.Resources.whitepawn;
            }
            else pieceImage = Chess.Properties.Resources.blackpawn;

            moveset = new List<int[]>(4);

            if (color) {
                moveset = new List<int[]>(4)
                {
                    new int[] { -1, 0 },
                    new int[] { -2, 0 },
                    //attacking
                    new int[] { -1, 1 },
                    new int[] { -1, -1 }
                };
            }
            else
            {
                moveset = new List<int[]>(4)
                {
                    new int[] { 1, 0 },
                    new int[] { 2, 0 },
                    //attacking
                    new int[] { 1, 1 },
                    new int[] { 1, -1 }
                };
            }
        }

        public override string ToString()
        {
            return "[P]";
        }
    }
}
