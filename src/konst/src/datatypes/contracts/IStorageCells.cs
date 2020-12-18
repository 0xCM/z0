//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static memory;

    public interface IStorageCells<T> : IDataType<Index<T>>
        where T : unmanaged
    {
        T[] Storage {get;}

        Count CellCount
            => Storage.Length;

        BitSize CellWidth
            => bitsize<T>();

        ByteSize CellSize
            => size<T>();

        ByteSize ISized.StorageSize
            => CellSize * CellCount;

        Index<T> IDataType<Index<T>>.Content
            => Storage;

        BitSize ISized.StorageWidth
            => (ulong)CellCount*CellWidth;
    }
}