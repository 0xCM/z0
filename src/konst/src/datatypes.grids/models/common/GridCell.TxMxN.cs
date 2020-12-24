//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    /// <summary>
    /// Defines an MxN indexed T-cell
    /// </summary>
    public readonly struct GridCell<T,M,N>
        where M : unmanaged
        where N : unmanaged
    {
        public M Row {get;}

        public N Col {get;}

        [MethodImpl(Inline)]
        public GridCell(M row, N col)
        {
            Row = row;
            Col = col;
        }
    }
}