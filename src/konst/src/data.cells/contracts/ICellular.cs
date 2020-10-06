//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICellular
    {
        Count CellCount {get;}
    }

    [Free]
    public interface ICellular<T> : ICellular
    {
        T[] Cells {get;}

        Count ICellular.CellCount
            => Cells.Length;

        ref T this[uint index]
            => ref Cells[index];
    }

    [Free]
    public interface ICellular<T,K> : ICellular<T>
        where K : unmanaged, Enum
    {
        ref T this[K index]
            => ref this[Enums.e32u(index)];
    }
}