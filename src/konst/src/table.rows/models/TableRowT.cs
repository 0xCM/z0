//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct TableRow<T>
        where T : struct
    {
        public uint RowIndex;

        public T Source;

        public readonly object[] Cells;

        [MethodImpl(Inline)]
        public TableRow(uint index, T src, object[] cells)
        {
            RowIndex = index;
            Source = src;
            Cells = cells;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Cells.Length;
        }

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => (uint)Cells.Length;
        }

        public ref object this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Cells[index];
        }

        public ref object this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Cells[index];
        }
    }
}