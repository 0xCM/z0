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
    public readonly struct Cell<T,K>
        where T : struct
        where K : unmanaged
    {        
        
        [MethodImpl(Inline)]
        public static implicit operator T(in Cell<T,K> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator Cell<T,K>(in Cell<T,K,K> src)
            => new Cell<T,K>(src.Data, src.Row, src.Col);

        public readonly T Data;

        public readonly K Row;

        public readonly K Col;

        [MethodImpl(Inline)]
        public Cell(T data, K row, K col)
        {
            Data = data;
            Row = row;
            Col = col;
        }
    }
}