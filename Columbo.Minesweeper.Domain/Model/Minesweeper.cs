﻿using System;

namespace Columbo.Minesweeper.Domain.Model
{
    public class Minesweeper : IMinesweeper
    {
        private IMinefield _minefield;

        public Minesweeper(IMinefield minefield)
        {
            _minefield = minefield;
        }

        public void reveal_tile_at(Coordinate coordinate)
        {
            _minefield.reveal_tile_at(coordinate);
        }
    }
}