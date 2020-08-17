//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct StringTableRows<T>
        where T : ITextual
    {        
        public readonly TableSpan<StringTableRow<T>> Data;

        [MethodImpl(Inline)]
        public static implicit operator StringTableRows<T>(StringTableRow<T>[] data)
            => new StringTableRows<T>(data);

        [MethodImpl(Inline)]
        public StringTableRows(StringTableRow<T>[] data)
            => Data = data;

        public ref StringTableRow<T> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref StringTableRow<T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

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
    }
}