﻿using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Columbo.Minesweeper.Application.Domain
{
    public interface IMinefield
    {
        void reveal_tile_at(Coordinate coordinate);
    }
}
