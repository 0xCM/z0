//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [DataType]
    public readonly struct StorageCells<T> : IStorageCells<T>
        where T : unmanaged
    {
        public readonly IndexedSeq<T> Data;

        [MethodImpl(Inline)]
        public StorageCells(T[] src)
            => Data = src;

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public ByteSize CellSize
        {
            [MethodImpl(Inline)]
            get => z.size<T>();
        }

        T[] IStorageCells<T>.Storage
            => Data;

        [MethodImpl(Inline)]
        public static implicit operator StorageCells<T>(T[] src)
            => new StorageCells<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T[](StorageCells<T> src)
            => src.Data;
    }
}