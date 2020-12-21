//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines formatting specifications for each cell in a row
    /// </summary>
    public readonly struct RowFormatSpec
    {
        public RowHeader Header {get;}

        public Index<CellFormatSpec> Cells {get;}

        [MethodImpl(Inline)]
        public RowFormatSpec(RowHeader header, CellFormatSpec[] src)
        {
            Header = header;
            Cells = src;
        }

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => Cells.Count;
        }
    }
}