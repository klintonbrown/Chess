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
            variableDistance = false;
            if (color)
            {
                pieceImage = Chess.Properties.Resources.whiteking;
            }
            else pieceImage = Chess.Properties.Resources.blackking;

            moveset = new List<int[]>(8)
            {
                new int[] { 0, 1 },
                new int[] { 0, -1 },
                new int[] { 1, 0 },
                new int[] { -1, 0 },
                new int[] { 1, 1 },
                new int[] { 1, -1 },
                new int[] { -1, 1 },
                new int[] { -1, -1 }
            };
        }

        public override string ToString()
        {
            return "[K]";
        }
    }
}

