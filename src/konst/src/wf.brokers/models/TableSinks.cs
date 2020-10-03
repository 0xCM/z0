//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TableSinks<T>
        where T : struct, ITable<T>
    {
        readonly TableSink<T>[] Data;

        [MethodImpl(Inline)]
        public static implicit operator TableSinks<T>(TableSink<T>[] src)
            => new TableSinks<T>(src);

        [MethodImpl(Inline)]
        public TableSinks(params TableSink<T>[] src)
            => Data = src;

        public Count Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ReadOnlySpan<TableSink<T>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<TableSink<T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref TableSink<T> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref z.seek(Edit, index);
        }

        public ref TableSink<T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref z.seek(Edit, (uint)index);
        }
    }
}