//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Control
    {
        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(in T src, int count)
            => ref Unsafe.Add(ref edit(in src), count); 

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(ReadOnlySpan<T> src, int count)
            => ref skip(in head(src), count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(Span<T> src, int count)
            => ref skip(in head(src), count);
    }
}