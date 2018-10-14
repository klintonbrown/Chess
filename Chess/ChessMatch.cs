using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class ChessMatch
    {
        private Board matchBoard;
        
        //current player - White: true; Black: false
        private bool currentPlayer;

        public ChessMatch()
        {
            matchBoard = new Board();
            currentPlayer = true;
            FindPossibleMoves();
        }

        public bool MakeMove(int pieceRow, int pieceCol, int targetRow, int targetCol)
        {
            ChessPiece activePiece = matchBoard.Spaces[pieceRow, pieceCol];

            if (activePiece != null && activePiece.Color == currentPlayer)
            {
                //if the square is a valid move for the piece, moves the piece
                if (IsValidMove(activePiece, targetRow, targetCol))
                {
                    activePiece.MoveCount++;
                    ChessPiece targetPiece = matchBoard.Spaces[targetRow, targetCol];
                    if (targetPiece != null)
                    {
                        matchBoard.GetPlayer(currentPlayer).CapturePiece(targetPiece);
                        matchBoard.GetPlayer(!currentPlayer).PieceCaptured(targetPiece);
                    }
                    if (activePiece.GetType() == typeof(Pawn))
                    {
                        if (targetRow == 0 || targetRow == 7)
                        {
                            activePiece = new Queen(currentPlayer);
                        }
                    }
                    matchBoard.Spaces[targetRow, targetCol] = activePiece;
                    matchBoard.Spaces[pieceRow, pieceCol] = null;
                    currentPlayer = !currentPlayer;
                    FindPossibleMoves();
                    return true;
                }
                else return false;
            }
            else return false;
        }

        private bool IsValidMove(ChessPiece cp, int targetI, int targetJ)
        {
            foreach (int[] arr in cp.CurrentMoves)
            {
                if(arr[0] == targetI && arr[1] == targetJ)
                {
                    return true;
                }
            }
            return false;
        }

        public void FindPossibleMoves()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    ChessPiece cp = matchBoard.Spaces[i, j];
                    if (cp != null)
                    {
                        cp.CurrentMoves.Clear();
                        if (cp.GetType() == typeof(Pawn))
                        {
                            if (cp.MoveCount == 0)
                            {
                                for (int cm = 0; cm < 2; cm++)
                                {
                                    int[] arr = cp.Moveset.ElementAt(cm);
                                    int x = i + arr[0];
                                    int y = j + arr[1];
                                    if ((x >= 0 && x < 8) && (y >= 0 && y < 8))
                                    {
                                        ChessPiece target = matchBoard.Spaces[x, y];
                                        if (target == null)
                                        {
                                            cp.CurrentMoves.Add(new int[] { x, y });
                                        }
                                        else break;
                                    }
                                }
                            }
                            else
                            {
                                int[] arr = cp.Moveset.ElementAt(0);
                                int x = i + arr[0];
                                int y = j + arr[1];
                                if ((x >= 0 && x < 8) && (y >= 0 && y < 8))
                                {
                                    ChessPiece target = matchBoard.Spaces[x, y];
                                    if (target == null)
                                    {
                                        cp.CurrentMoves.Add(new int[] { x, y });
                                    }
                                }
                            }
                            for (int cm = 2; cm < cp.Moveset.Count; cm++)
                            {
                                int[] arr = cp.Moveset.ElementAt(cm);
                                int x = i + arr[0];
                                int y = j + arr[1];
                                if ((x >= 0 && x < 8) && (y >= 0 && y < 8))
                                {
                                    ChessPiece target = matchBoard.Spaces[x, y];
                                    if (target != null && target.Color != cp.Color)
                                    {
                                        cp.CurrentMoves.Add(new int[] { x, y });
                                    }
                                }
                            }
                        } //pawns are special
                        else
                        {
                            for (int cm = 0; cm < cp.Moveset.Count; cm++)
                            {
                                int[] arr = cp.Moveset.ElementAt(cm);
                                int x = i + arr[0];
                                int y = j + arr[1];
                                if ((x >= 0 && x < 8) && (y >= 0 && y < 8))
                                {
                                    ChessPiece target = matchBoard.Spaces[x, y];
                                    if (target == null)
                                    {
                                        cp.CurrentMoves.Add(new int[] { x, y });
                                    }
                                    else if(target.Color != cp.Color){
                                        cp.CurrentMoves.Add(new int[] { x, y });
                                        if (cp.VariableDistance)
                                        {
                                            cm = (cm + 7) - ((cm + 7) % 7) - 1;
                                        }
                                    }
                                    else if (cp.VariableDistance)
                                    {
                                        //if the piece's path is blocked and piece is capable of
                                        //moving beyond that space, skips forward in the
                                        //possible moves array to the next block of possible moves.
                                        cm = (cm + 7) - ((cm + 7) % 7) - 1;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public bool CurrentPlayer
        {
            get
            {
                return currentPlayer;
            }
        }

        public Bitmap GenerateBoardImage()
        {
            Bitmap bmp = (Bitmap) matchBoard.BoardBMP.Clone();
            using (Graphics g = Graphics.FromImage(bmp))
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (matchBoard.Spaces[i,j] != null)
                        {
                            g.DrawImage(matchBoard.Spaces[i, j].Image, j * 33, i * 33);
                        }
                    }
                }
            }
            return bmp;
        }

        public Bitmap GenerateCapturedImage(bool player)
        {
            Bitmap bmp = new Bitmap(264, 66, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                using (System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.LightBlue))
                {
                    g.FillRectangle(myBrush, new Rectangle(0, 0, 264, 66));
                } // myBrush will be disposed at this line
                int x = 0;
                int y = 0;
                foreach (ChessPiece cp in matchBoard.GetPlayer(player).CapturedPieces)
                {
                    g.DrawImage(cp.Image, x, y);
                    x += 33;
                    if (x == 264)
                    {
                        x = 0;
                        y += 33;
                    }
                }
            }
            return bmp;
        }

        public override string ToString()
        {
            return matchBoard.ToString();
        }
    }
}
