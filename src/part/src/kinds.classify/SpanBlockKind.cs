//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Flags]
    public enum SpanBlockKind : ushort
    {
        None,

        Sb8 = CellWidth.W8,

        Sb16 = CellWidth.W8 | CellWidth.W16,

        Sb32 = CellWidth.W8 | CellWidth.W16 | CellWidth.W32,

        Sb64 = CellWidth.Numeric,

        Sb128 = CellWidth.W128 | CellWidth.Numeric,

        Sb256 = CellWidth.W256 | CellWidth.W128 | CellWidth.Numeric,

        Sb512 = CellWidth.W512 | CellWidth.W256 | CellWidth.W128 | CellWidth.Numeric,
    }
}