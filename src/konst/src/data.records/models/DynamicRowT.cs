//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct DynamicRow<T> : IDynamicRow<T>
        where T : struct
    {
        public uint RowIndex {get;}

        public T Source {get;}

        public dynamic[] Cells {get;}

        [MethodImpl(Inline)]
        public DynamicRow(uint index, in T src, dynamic[] cells)
        {
            RowIndex = index;
            Source = src;
            Cells = cells;
        }

        [MethodImpl(Inline)]
        public DynamicRow<T> UpdateSource(uint index, in T src)
            => new DynamicRow<T>(index, src, Cells);

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => (uint)Cells.Length;
        }

        public ref dynamic this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Cells[index];
        }

        public ref dynamic this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Cells[index];
        }
    }
}