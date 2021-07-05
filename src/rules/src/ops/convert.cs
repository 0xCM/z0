//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void convert<T>(Vec<T> src, out SpanVec<T> dst)
            => dst = src;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void convert<T>(Vec<T> src, out ImmutableVec<T> dst)
            => dst = src;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void convert<T>(SpanVec<T> src, out ImmutableVec<T> dst)
            => dst = src;
    }
}