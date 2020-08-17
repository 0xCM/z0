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
        public readonly TableSpan<StringTableCell> Data;

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

        public CellCount Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref StringTableCell this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}