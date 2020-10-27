//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.InteropServices.MemoryMarshal;

    using static Konst;
    using static z;

    partial class Spans
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<byte> src, int offset, int length)
            where T : unmanaged
                => Cast<byte,T>(src.Slice(offset, (int)(length * size<T>())));
    }
}