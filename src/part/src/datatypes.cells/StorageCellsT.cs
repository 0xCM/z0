//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Datatype]
    public readonly struct StorageCells<T> : IStorageCells<T>
        where T : unmanaged
    {
        public Index<T> Cells {get;}

        [MethodImpl(Inline)]
        public StorageCells(T[] src)
            => Cells  = src;

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => Cells.Count;
        }

        public ByteSize CellSize
        {
            [MethodImpl(Inline)]
            get => memory.size<T>();
        }

        [MethodImpl(Inline)]
        public static implicit operator StorageCells<T>(T[] src)
            => new StorageCells<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T[](StorageCells<T> src)
            => src.Cells.Storage;
    }
}