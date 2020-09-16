//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct StringTableRow<T>
        where T : ITextual
    {
        public readonly StringTableCells<T> Cells;

        [MethodImpl(Inline)]
        public StringTableRow(T[] cells)
            => Cells = cells;

        [MethodImpl(Inline)]
        public StringTableRow(StringTableCell<T>[] cells)
            => Cells = cells;

        public int Length
        {
            [MethodImpl(Inline)]
            get => Cells.Length;
        }

        public Count Count
        {
            [MethodImpl(Inline)]
            get => (uint)Cells.Length;
        }

        public ref StringTableCell<T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Cells[index];
        }
    }
}