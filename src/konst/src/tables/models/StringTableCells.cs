//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct StringTableCells
    {
        readonly TableSpan<StringTableCell> Storage;

        [MethodImpl(Inline)]
        public static implicit operator StringTableCells(StringTableCell[] src)
            => new StringTableCells(src);

        [MethodImpl(Inline)]
        public static implicit operator StringTableCells(string[] src)
            => new StringTableCells(src);

        [MethodImpl(Inline)]
        public StringTableCells(string[] src)
            => Storage= src.Select(x => new StringTableCell(x));

        [MethodImpl(Inline)]
        public StringTableCells(StringTableCell[] src)
            => Storage= src;

        public Span<StringTableCell> Edit
        {
            [MethodImpl(Inline)]
            get => Storage.Edit;
        }

        public ReadOnlySpan<StringTableCell> View
        {
            [MethodImpl(Inline)]
            get => Storage.Edit;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Storage.Length;
        }

        public CellCount Count
        {
            [MethodImpl(Inline)]
            get => Storage.Length;
        }

        public ref StringTableCell this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Storage[index];
        }

        public ref StringTableCell this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Storage[index];
        }
    }
}