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