using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Board
    {

        private ChessPiece[,] spaces;

        public Board()
        {
            spaces = new ChessPiece[8, 8];
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            //initialize white pieces
            spaces[7, 0] = new Rook(true);
            spaces[7, 1] = new Knight(true);
            spaces[7, 2] = new Bishop(true);
            spaces[7, 3] = new Queen(true);
            spaces[7, 4] = new King(true);
            spaces[7, 5] = new Bishop(true);
            spaces[7, 6] = new Knight(true);
            spaces[7, 7] = new Rook(true);

            //initialize black pieces
            spaces[0, 0] = new Rook(false);
            spaces[0, 1] = new Knight(false);
            spaces[0, 2] = new Bishop(false);
            spaces[0, 3] = new Queen(false);
            spaces[0, 4] = new King(false);
            spaces[0, 5] = new Bishop(false);
            spaces[0, 6] = new Knight(false);
            spaces[0, 7] = new Rook(false);

            //initialize pawns
            for (int i = 0; i < 8; i++)
            {
                spaces[6, i] = new Pawn(true);
                spaces[1, i] = new Pawn(false);
            }
            
        }

        public void MakeMove(string piece, string move)
        {
            int i = int.Parse(piece.Substring(0, 1));
            int j = int.Parse(piece.Substring(2, 1));
            ChessPiece activePiece = spaces[i, j];

            int i2 = int.Parse(move.Substring(0, 1));
            int j2 = int.Parse(move.Substring(2, 1));

            if (IsValidMove(i, j, i2, j2))
            {
                spaces[i2, j2] = activePiece;
                spaces[i, j] = null;
            }
        }

        /* Checks if an entered move is valid.
         */
        private bool IsValidMove(int piece1, int piece2, int square1, int square2)
        {
            ArrayList possibleMoves = GetPossibleMoves(piece1, piece2);
            foreach (int[] arr in possibleMoves)
            {
                if (arr[0] == square1 && arr[1] == square2)
                {
                    return true;
                }
            }

            return false;
        }

        /* Determines the possible moves a selected piece can make.
         */
        private ArrayList GetPossibleMoves(int pieceI, int pieceJ)
        {
            int[,] pieceMoves = spaces[pieceI, pieceJ].Moveset;
            ArrayList possibleMoves = new ArrayList();

            for (int i = 0; i < pieceMoves.GetLength(0); i++)
            {
                int tempX = pieceI + pieceMoves[i, 0];
                int tempY = pieceJ + pieceMoves[i, 1];

                if (tempX >= 0 && tempX < 8 && tempY >= 0 && tempY < 8) {
                    ChessPiece temp = spaces[pieceI + pieceMoves[i, 0], pieceJ + pieceMoves[i, 1]];
                    if (temp == null || temp.Color != spaces[pieceI, pieceJ].Color)
                    {
                        possibleMoves.Add(new int[] { pieceI + pieceMoves[i, 0], pieceJ + pieceMoves[i, 1] });
                    }
                }
            }
            return possibleMoves;
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (spaces[i, j] != null)
                    {
                        result = result + spaces[i,j].ToString();
                    }
                    else result = result + "[   ]";
                }
                result = result + "\r\n";
            }
            return result;
        }
    }
}
