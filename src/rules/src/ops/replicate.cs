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
        [Op, Closures(Closure)]
        public static Vec<T> replicate<T>(in Vec<T> src)
        {
            var length = src.Length;
            var dst = vec<T>(alloc<T>(length));
            copy(src,dst);
            return dst;
        }

        [Op, Closures(Closure)]
        public static SpanVec<T> replicate<T>(in SpanVec<T> src)
        {
            var length = src.Length;
            var dst = vec<T>(alloc<T>(length));
            copy(src,dst);
            return dst;
        }

        [Op, Closures(Closure)]
        public static ImmutableVec<T> replicate<T>(in ImmutableVec<T> src)
        {
            var length = src.Length;
            var dst = vec<T>(span<T>(length));
            copy(src.Storage,dst.Storage);
            return dst;
        }
    }
}