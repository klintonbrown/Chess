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
            variableDistance = true;

            if (color)
            {
                pieceImage = Chess.Properties.Resources.whiterook;
            }
            else pieceImage = Chess.Properties.Resources.blackrook;

            moveset = new List<int[]>(28);

            for (int i = 0; i < 7; i++)
            {
                moveset.Add(new int[] { 0, i + 1 });
            }
            for (int i = 0; i < 7; i++)
            {
                moveset.Add(new int[] { 0, 0 - (i + 1) });
            }
            for (int i = 0; i < 7; i++)
            {
                moveset.Add(new int[] { i + 1, 0 });
            }
            for (int i = 0; i < 7; i++)
            {
                moveset.Add(new int[] { 0 - (i + 1), 0 });
            }
        }

        public override string ToString()
        {
            return "[R]";
        }
    }
}
