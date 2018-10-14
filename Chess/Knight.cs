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
            variableDistance = false;
            if (color)
            {
                pieceImage = Chess.Properties.Resources.whiteknight;
            }
            else pieceImage = Chess.Properties.Resources.blackknight;

            moveset = new List<int[]>(8)
            {
                new int[] { 1, 2 },
                new int[] { 1, -2 },
                new int[] { 2, 1 },
                new int[] { 2, -1 },
                new int[] { -1, 2 },
                new int[] { -1, -2 },
                new int[] { -2, 1 },
                new int[] { -2, -1 }
            };
        }

        public override string ToString()
        {
            return "[k]";
        }
    }
}
