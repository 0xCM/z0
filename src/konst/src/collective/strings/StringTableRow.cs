//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct StringTableRow
    {
        StringTableCells Data;

        [MethodImpl(Inline)]
        public StringTableRow(string[] cells)
            => Data = cells;

        [MethodImpl(Inline)]
        public static implicit operator StringTableRow(string[] src)
            => new StringTableRow(src);

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

        public Span<StringTableCell> Cells
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ref StringTableCell this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref StringTableCell this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        [MethodImpl(Inline)]
        public StringTableRow Fill(StringTableCell[] src)
        {
            Data = src;
            return this;
        }
    }
}