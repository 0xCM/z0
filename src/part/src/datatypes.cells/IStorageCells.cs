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
        Index<T> Cells {get;}

        Count CellCount
            => Cells.Count;

        BitSize CellWidth
            => bitsize<T>();

        ByteSize CellSize
            => size<T>();

        Index<T> IDataType<Index<T>>.Content
            => Cells;

        BitSize ISized.Width
            => (ulong)CellCount*CellWidth;
    }
}