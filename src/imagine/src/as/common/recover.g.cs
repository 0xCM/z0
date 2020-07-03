//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.InteropServices.MemoryMarshal;

    partial struct As
    {
       [MethodImpl(Inline)]
        public static Span<T> recover<S,T>(Span<S> src)
            => cover(@as<S,T>(ref first(src)), size<T>()/size<S>());

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> recover<S,T>(ReadOnlySpan<S> src)
            => cover(@as<S,T>(ref edit(first(src))), size<T>()/size<S>());
    }
}