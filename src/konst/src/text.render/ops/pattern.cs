//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Render
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static RenderPattern<T> pattern<T>(string src, T t = default)
            => src;

        [MethodImpl(Inline)]
        public static RenderPattern<A0,A1> pattern<A0,A1>(string src, A0 a0 = default, A1 a1 = default)
            => src;

        [MethodImpl(Inline)]
        public static RenderPattern<A0,A1,A2> pattern<A0,A1,A2>(string src, A0 a0 = default, A1 a1 = default, A2 a2 = default)
            => src;

        [MethodImpl(Inline)]
        public static RenderPattern<A0,A1,A2,A3> pattern<A0,A1,A2,A3>(string src, A0 a0 = default, A1 a1 = default, A2 a2 = default, A3 a3 = default)
            => src;
    }
}