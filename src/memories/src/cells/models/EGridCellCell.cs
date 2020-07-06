//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct EGridCell<T,K>
        where T : struct
        where K : unmanaged, Enum
    {        
        public readonly K Row;

        public readonly K Col;

        public readonly T Data;

        [MethodImpl(Inline)]
        public EGridCell(K row, K col, T data)
        {
            Row = row;
            Col = col;
            Data = data;
        }
    }

    /// <summary>
    /// Defines an MxN indexed E-cell
    /// </summary>
    public readonly struct EGridCell<T,M,N>
        where T : struct
        where M : unmanaged, Enum
        where N : unmanaged, Enum
    {        
        public readonly M Row;

        public readonly N Col;

        public readonly T Data;

        [MethodImpl(Inline)]
        public EGridCell(M row, N col, T data)
        {
            Row = row;
            Col = col;
            Data = data;
        }
    }        
}