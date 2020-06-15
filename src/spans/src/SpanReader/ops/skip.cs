//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial struct SpanReader
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ref readonly T skip<T>(in T src, int count)
            => ref Unsafe.Add(ref edit(in src), count); 

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ref readonly T skip<T>(ReadOnlySpan<T> src, int count)
            => ref skip(in head(src), count);
    }
}