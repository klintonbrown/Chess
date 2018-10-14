using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class ChessPlayer
    {
        //represents player color: true is white; false is black
        private bool color;
        private bool inCheck;
        private List<ChessPiece> playerPieces;
        private List<ChessPiece> capturedPieces;

        public ChessPlayer(bool playerColor)
        {
            color = playerColor;
            inCheck = false;
            playerPieces = new List<ChessPiece>(16)
            {
                new Rook(color),
                new Knight(color),
                new Bishop(color),
                new Queen(color),
                new King(color),
                new Bishop(color),
                new Knight(color),
                new Rook(color)
            };

            for (int i = 0; i < 8; i++)
            {
                playerPieces.Add(new Pawn(color));
            }

            capturedPieces = new List<ChessPiece>();
        }

        public void CapturePiece(ChessPiece captured)
        {
            capturedPieces.Add(captured);
        }

        public void PieceCaptured(ChessPiece captured)
        {
            playerPieces.Remove(captured);
        }

        public bool Color
        {
            get
            {
                return color;
            }
        }

        public List<ChessPiece> PlayerPieces
        {
            get
            {
                return playerPieces;
            }
        }

        public List<ChessPiece> CapturedPieces
        {
            get
            {
                return capturedPieces;
            }
        }
    }
}
