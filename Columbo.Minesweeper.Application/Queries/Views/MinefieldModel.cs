﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Columbo.Minesweeper.Application.Queries.Views
{
    public class MinefieldModel
    {
        public IEnumerable<IEnumerable<TileModel>> tiles { get; set; }
    }
}