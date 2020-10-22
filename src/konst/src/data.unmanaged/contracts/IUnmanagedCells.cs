//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    public interface IUnmanagedContent<T> : IContented<T>
        where T : unmanaged
    {

    }

    public interface IUnmanagedCells<T> : IContented<T[]>
        where T : unmanaged
    {
        T[] Storage {get;}

        uint CellCount => (uint)Storage.Length;

        ByteSize CellSize
            => z.size<T>();

        T[] IContented<T[]>.Content
            => Storage;
    }

    public interface IUnmanagedCells : IUnmanagedCells<byte>
    {

    }
}