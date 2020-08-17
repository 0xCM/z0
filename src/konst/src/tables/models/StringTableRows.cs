//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct StringTableRows
    {        
        public readonly TableSpan<StringTableRow> Data;

        [MethodImpl(Inline)]
        public static implicit operator StringTableRows(StringTableRow[] data)
            => new StringTableRows(data);

        [MethodImpl(Inline)]
        public StringTableRows(StringTableRow[] data)
            => Data = data;

        public ref StringTableRow this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref StringTableRow this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }
    }
}