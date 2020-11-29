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

    public interface IStorageCells<T> : IDataType<IndexedSeq<T>>
        where T : unmanaged
    {
        T[] Storage {get;}

        Count CellCount
            => Storage.Length;

        BitSize CellWidth
            => z.bitsize<T>();

        ByteSize CellSize
            => z.size<T>();

        ByteSize ISized.StorageSize
            => CellSize * CellCount;

        IndexedSeq<T> IDataType<IndexedSeq<T>>.Content
            => Storage;

        BitSize ISized.StorageWidth
            => (ulong)CellCount*CellWidth;
    }
}