//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct StringTableCells<T>
    {
        public TableSpan<StringTableCell<T>> Data;

        [MethodImpl(Inline)]
        public static implicit operator StringTableCells(StringTableCells<T> src)
            => new StringTableCells(src.Data.Storage.Select(x => x.Format()));

        [MethodImpl(Inline)]
        public static implicit operator StringTableCells<T>(StringTableCell<T>[] src)
            => new StringTableCells<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator StringTableCells<T>(T[] src)
            => new StringTableCells<T>(src);

        [MethodImpl(Inline)]
        public StringTableCells(T[] src)
            => Data= src.Select(x => new StringTableCell<T>(x));

        [MethodImpl(Inline)]
        public StringTableCells(StringTableCell<T>[] src)
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

        public ref StringTableCell<T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
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


        [MethodImpl(Inline)]
        public StringTableCells<T> Fill(StringTableCell<T>[] src)
        {
            Data = src;
            return this;
        }
    }
}