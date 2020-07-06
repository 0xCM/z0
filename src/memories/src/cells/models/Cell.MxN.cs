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
    /// Defines an MxN indexed T-cell
    /// </summary>
    public readonly struct Cell<T,M,N>
        where T : struct
        where M : unmanaged
        where N : unmanaged
    {        

        [MethodImpl(Inline)]
        public static implicit operator T(in Cell<T,M,N> src)
            => src.Data;

        public readonly T Data;

        public readonly M Row;

        public readonly N Col;


        [MethodImpl(Inline)]
        public Cell(T data, M row, N col)
        {
            Row = row;
            Col = col;
            Data = data;
        }
    }    
}