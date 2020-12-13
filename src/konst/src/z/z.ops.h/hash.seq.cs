//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static uint hash<T>(ReadOnlySpan<T> src)
            => alg.hash.calc(src);

        [MethodImpl(Inline)]
        public static uint hash<T>(Span<T> src)
            => alg.hash.calc(src);

        [MethodImpl(Inline)]
        public static uint hash<T>(T[] src)
            => alg.hash.calc(src);
    }
}