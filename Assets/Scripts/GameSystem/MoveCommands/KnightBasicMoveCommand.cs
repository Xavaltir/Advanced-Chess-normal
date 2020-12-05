﻿using System.Collections.Generic;
using BoardSystem;
using GameSystem.Models;
using MoveSystem;
namespace GameSystem.MoveCommands
{
    public class KnightBasicMoveCommand : AbstractBasicMoveCommand
    {
        public override List<Tile> Tiles(Board<ChessPiece> board, ChessPiece piece)
        {
            var validMoves = new MovementHelper(board, piece)
                .Collect(2, 1, 1)
                .Collect(2, -1, 1)
                .Collect(-2, 1, 1)
                .Collect(-2, -1, 1)
                .Collect(1, 2, 1)
                .Collect(1, -2, 1)
                .Collect(-1, 2, 1)
                .Collect(-1, -2, 1)
                .Generate();

            return validMoves;
        }
    }
}
