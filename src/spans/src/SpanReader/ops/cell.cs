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
        [MethodImpl(Inline), Op]
        public ref readonly byte cell(ReadOnlySpan<byte> src, int offset)
            => ref skip(src, offset);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ref readonly T cell<T>(ReadOnlySpan<T> src, int offset)
            => ref skip(src, offset);
    }
}