//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    partial class Root
    {
        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(in T src, byte count)
            => ref Add(ref edit(in src), count); 

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(in T src, int count)
            => ref Add(ref edit(in src), count); 

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(ReadOnlySpan<T> src, byte count)
            => ref skip(in As.first(src), count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(Span<T> src, byte count)
            => ref skip(in As.first(src), count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(ReadOnlySpan<T> src, int count)
            => ref skip(in As.first(src), count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(Span<T> src, int count)
            => ref skip(in As.first(src), count);
    }
}