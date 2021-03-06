﻿namespace Gadz.Tetris.Model
{
    public class PieceBuilder
    {
        #region fields

        private PieceType _pieceType;
        private Point _position;
        private int _rotation;
        private Board _board;

        #endregion

        #region methods

        public PieceBuilder OfType(PieceType type)
        {
            _pieceType = type;
            return this;
        }

        public PieceBuilder OnPosition(Point position)
        {
            _position = position;
            return this;
        }

        public PieceBuilder WithRotation(int rotation)
        {
            _rotation = rotation;
            return this;
        }

        public PieceBuilder OnBoard(Board board)
        {
            _board = board;
            return this;
        }

        public Piece Build()
        {
            return new Piece(_pieceType, _position, _rotation, _board);
        }

        #endregion
    }
}