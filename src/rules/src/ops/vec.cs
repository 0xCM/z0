//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Rules
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vec<T> vec<T>(T[] src)
            => new Vec<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SpanVec<T> vec<T>(Span<T> src)
            => new SpanVec<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ImmutableVec<T> vec<T>(ReadOnlySpan<T> src)
            => new ImmutableVec<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SpanVec<T> vec<T>(in SpanVecs<T> src, uint index)
        {
            var length = src.Dim;
            var offset = index*length;
            if(offset + length > src.Storage.Length)
                return SpanVec<T>.Empty;
            else
                return vec(slice(src.Storage, offset, length));
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ImmutableVec<T> vec<T>(in ImmutableVecs<T> src, uint index)
        {
            var length = src.Dim;
            var offset = index*length;
            if(offset + length > src.Storage.Length)
                return ImmutableVec<T>.Empty;
            else
                return vec(slice(src.Storage,offset,length));
        }
    }
}