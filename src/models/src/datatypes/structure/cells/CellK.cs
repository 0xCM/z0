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
        public readonly K Row;

        public readonly K Col;

        public readonly T Data;

        [MethodImpl(Inline)]
        public Cell(K row, K col, T data)
        {
            Row = row;
            Col = col;
            Data = data;
        }
    }

    /// <summary>
    /// Defines an MxN indexed T-cell
    /// </summary>
    public readonly struct Cell<T,M,N>
        where T : struct
        where M : unmanaged
        where N : unmanaged
    {        
        public readonly M Row;

        public readonly N Col;

        public readonly T Data;

        [MethodImpl(Inline)]
        public Cell(M row, N col, T data)
        {
            Row = row;
            Col = col;
            Data = data;
        }
    }    
}