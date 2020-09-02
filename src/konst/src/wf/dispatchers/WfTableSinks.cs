//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct WfTableSinks<T>
        where T : struct, ITable<T>
    {
        readonly WfTableSink<T>[] Data;

        [MethodImpl(Inline)]
        public static implicit operator WfTableSinks<T>(WfTableSink<T>[] src)
            => new WfTableSinks<T>(src);

        [MethodImpl(Inline)]
        public WfTableSinks(params WfTableSink<T>[] src)
            => Data = src;

        public Count32 Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ReadOnlySpan<WfTableSink<T>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<WfTableSink<T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref WfTableSink<T> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref z.seek(Edit, index);
        }

        public ref WfTableSink<T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref z.seek(Edit, (uint)index);
        }
    }
}