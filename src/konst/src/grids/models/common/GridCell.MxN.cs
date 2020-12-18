//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    /// <summary>
    /// Defines an MxN indexed T-cell
    /// </summary>
    public readonly struct GridCell<T,M,N>
        where T : struct
        where M : unmanaged
        where N : unmanaged
    {
        public T Data {get;}

        public M Row {get;}

        public N Col {get;}

        [MethodImpl(Inline)]
        public GridCell(T data, M row, N col)
        {
            Row = row;
            Col = col;
            Data = data;
        }

        [MethodImpl(Inline)]
        public static implicit operator T(in GridCell<T,M,N> src)
            => src.Data;
    }
}