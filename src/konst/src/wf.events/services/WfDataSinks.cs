//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct WfDataSinks<T>
        where T : struct
    {
        readonly WfDataSink<T>[] Data;

        [MethodImpl(Inline)]
        public static implicit operator WfDataSinks<T>(WfDataSink<T>[] src)
            => new WfDataSinks<T>(src);

        [MethodImpl(Inline)]
        public WfDataSinks(params WfDataSink<T>[] src)
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

        public ReadOnlySpan<WfDataSink<T>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<WfDataSink<T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref WfDataSink<T> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref z.seek(Edit, index);
        }

        public ref WfDataSink<T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref z.seek(Edit, (uint)index);
        }
    }
}