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
    /// Defines a K-indexed T-cell
    /// </summary>
    public readonly struct GridCell<T,K>
        where K : unmanaged
    {
        public K Row {get;}

        public K Col {get;}

        [MethodImpl(Inline)]
        public GridCell(K row, K col)
        {
            Row = row;
            Col = col;
        }

        [MethodImpl(Inline)]
        public static implicit operator GridCell<T,K>(in GridCell<T,K,K> src)
            => new GridCell<T,K>(src.Row, src.Col);
    }
}