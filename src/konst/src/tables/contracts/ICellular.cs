//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface ICellular
    {
        CellCount CellCount {get;}
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ICellular<T> : ICellular
    {
        T[] Cells {get;}

        CellCount ICellular.CellCount 
            => Cells.Length;
        
        ref T this[uint index]
            => ref Cells[index];
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ICellular<T,K> : ICellular<T>
        where K : unmanaged, Enum
    {
        ref T this[K index] 
            => ref this[Enums.e32u(index)];
    }
}