//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a K-indexed T-cell
    /// </summary>
    public readonly struct GridCell<T,K>
        where T : struct
        where K : unmanaged
    {
        public T Data {get;}

        public K Row {get;}

        public K Col {get;}

        [MethodImpl(Inline)]
        public GridCell(T data, K row, K col)
        {
            Data = data;
            Row = row;
            Col = col;
        }

        [MethodImpl(Inline)]
        public static implicit operator T(in GridCell<T,K> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator GridCell<T,K>(in GridCell<T,K,K> src)
            => new GridCell<T,K>(src.Data, src.Row, src.Col);
    }
}