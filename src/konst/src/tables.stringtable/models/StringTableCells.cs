//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct StringTableCells
    {
        TableSpan<StringTableCell> Data;

        [MethodImpl(Inline)]
        public static implicit operator StringTableCells(StringTableCell[] src)
            => new StringTableCells(src);

        [MethodImpl(Inline)]
        public static implicit operator StringTableCells(string[] src)
            => new StringTableCells(src);

        [MethodImpl(Inline)]
        public StringTableCells(string[] src)
            => Data= src.Select(x => new StringTableCell(x));

        [MethodImpl(Inline)]
        public StringTableCells(StringTableCell[] src)
            => Data= src;

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public Count Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public Span<StringTableCell> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<StringTableCell> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
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
        public StringTableCells Fill(StringTableCell[] src)
        {
            Data = src;
            return this;
        }
    }
}