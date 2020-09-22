//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct StringTableRow<T>
    {
        StringTableCells<T> Data;

        [MethodImpl(Inline)]
        public StringTableRow(T[] cells)
            => Data = cells;

        [MethodImpl(Inline)]
        public StringTableRow(StringTableCell<T>[] cells)
            => Data = cells;

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public Count Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public Span<StringTableCell<T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<StringTableCell<T>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public ref StringTableCell<T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        [MethodImpl(Inline)]
        public StringTableRow<T> Fill(StringTableCell<T>[] src)
        {
            Data = src;
            return this;
        }
    }
}